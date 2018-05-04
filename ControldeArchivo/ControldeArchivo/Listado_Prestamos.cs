using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControldeArchivo
{
    public partial class Listado_Prestamos : Form
    {
        SqlConnection Cx;
        public Listado_Prestamos()
        {
            InitializeComponent();
        }
        private void Carga_Datos()
        {
            using (Cx = new SqlConnection(Properties.Settings.Default.Cadena))
            {
                try
                {
                    Cx.Open();
                    SqlCommand Cmd = new SqlCommand
                    {
                        CommandType = CommandType.Text,
                        CommandText = "SELECT Prestamos.Id_Prestamo, Personal.Nombre, View_DocumentosXPrestamo.Total, Prestamos.Fecha_Inicio, Prestamos.Fecha_Fin, STUFF((Select ', ' + View_DetallePrestamo.Detalle From View_DetallePrestamo Inner Join  Prestamos on Prestamos.Id_Prestamo = view_DetallePrestamo.Id_Prestamo FOR XML PATH('')),1, 2, '') as Documentos, Prestamos.Observaciones FROM Prestamos INNER JOIN View_DocumentosXPrestamo ON Prestamos.Id_Prestamo = View_DocumentosXPrestamo.Id_Prestamo INNER JOIN Personal ON Prestamos.Id_Solicitante = Personal.Id_Personal",
                        Connection = Cx
                    };
                    SqlDataAdapter DA = new SqlDataAdapter(Cmd);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    dataGridView1.DataSource = DT;
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Button_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Edita_Click(object sender, EventArgs e)
        {
            int Columna = 0;
            int Fila = 0;
            int Id_Localidad = 0;
            Fila = dataGridView1.CurrentCellAddress.Y;
            try
            {
                Id_Localidad = Int32.Parse(dataGridView1[Columna, Fila].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Id_Localidad == 0)
            {
                MessageBox.Show("Debe de Seleccionar el Prestamo que se quiere editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Edita_Localidad frm = new Edita_Localidad();
                frm.CargaDatos(Id_Localidad);
                frm.ShowDialog();
                Carga_Datos();
            }
        }
    }
}
