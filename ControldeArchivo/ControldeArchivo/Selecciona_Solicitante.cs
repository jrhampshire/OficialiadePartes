using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControldeArchivo
{
    public partial class Selecciona_Solicitante : Form
    {
        SqlConnection Cx;

        public Selecciona_Solicitante()
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
                        CommandText = "Select Id_Personal as ID, Nombre from Personal Order by Nombre",
                        Connection = Cx
                    };
                    SqlDataAdapter DA = new SqlDataAdapter(Cmd);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    dataGridView1.DataSource = DT;
                   

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            int Columna = 0;
            int Fila = 0;
            int Id_Persona = 0;
            Fila = dataGridView1.CurrentCellAddress.Y;
            try
            {
                Id_Persona = Int32.Parse(dataGridView1[Columna, Fila].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Id_Persona == 0)
            {
                MessageBox.Show("Debe de Seleccionar la Persona que se quiere editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                EditaPersona frm = new EditaPersona();
                frm.CargaDatos(Id_Persona);
                frm.ShowDialog();
                Carga_Datos();
            }
        }
    }
}
