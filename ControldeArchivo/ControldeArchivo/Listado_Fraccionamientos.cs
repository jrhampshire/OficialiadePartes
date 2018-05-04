using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ControldeArchivo
{
    public partial class Listado_Fraccionamientos : Form
    {
        public Listado_Fraccionamientos()
        {
            InitializeComponent();
        }

        private void toolStripButton_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listado_Fraccionamientos_Load(object sender, EventArgs e)
        {
            Carga_Datos();
        }

        private void Carga_Datos()
        {
            SqlConnection Cx;

            using (Cx = new SqlConnection(Properties.Settings.Default.Cadena))
            {
                try
                {
                    Cx.Open();
                    SqlCommand Cmd = new SqlCommand
                    {
                        CommandType = CommandType.Text,
                        CommandText = "Select * from View_ListadodeFraccionamientos Order by Localidad, Nombre",
                        Connection = Cx
                    };
                    SqlDataAdapter DA = new SqlDataAdapter(Cmd);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    dataGridView1.DataSource = DT;
                   // dataGridView1.Sort(this.dataGridView1.Columns["Descripcion"], ListSortDirection.Ascending);

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

        private void toolStripButton_Borrar_Click(object sender, EventArgs e)
        {
            int Columna = 0;
            int Fila = 0;
            int Id_Fraccionamiento = 0;
            Fila = dataGridView1.CurrentCellAddress.Y;
            Id_Fraccionamiento = Int32.Parse(dataGridView1[Columna, Fila].Value.ToString());
            if (Id_Fraccionamiento == 0)
            {
                MessageBox.Show("Debe de Seleccionar la Localidad que se quiere editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                SqlConnection Cx;
                using (Cx = new SqlConnection(Properties.Settings.Default.Cadena))
                {
                    try
                    {
                        Cx.Open();
                        SqlCommand Cmd = new SqlCommand
                        {
                            CommandType = CommandType.Text,
                            CommandText = "Delete Fraccionamiento where id_Fraccionamiento = @Fraccionamiento"
                        };
                        Cmd.Parameters.AddWithValue("@Fraccionamiento", Id_Fraccionamiento);
                        Cmd.Connection = Cx;
                        Cmd.ExecuteNonQuery();
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
        }

        private void toolStripButton_Agrega_Click(object sender, EventArgs e)
        {
            Nuevo_Fraccionamiento frm =new Nuevo_Fraccionamiento();
            frm.ShowDialog();
            Carga_Datos();
        }

        private void toolStripButton_Edita_Click(object sender, EventArgs e)
        {
            int Columna = 0;
            int Fila = 0;
            int Id_Fraccionamiento = 0;
            string _Fraccionamiento;
            string _Localidad;
            Fila = dataGridView1.CurrentCellAddress.Y;
            try
            {
                Id_Fraccionamiento = Int32.Parse(dataGridView1[Columna, Fila].Value.ToString());
                 _Fraccionamiento = dataGridView1[2, Fila].Value.ToString();
                 _Localidad = dataGridView1[1, Fila].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Id_Fraccionamiento == 0)
            {
                MessageBox.Show("Debe de Seleccionar la Localidad que se quiere editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {                
                Edita_Fraccionamiento frm = new Edita_Fraccionamiento();                
                frm.CargaDatos(Id_Fraccionamiento, _Localidad, _Fraccionamiento);
                frm.ShowDialog();
                Carga_Datos();
            }
           
        }
    }
}
