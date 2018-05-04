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
    public partial class Listado_Localidades : Form
    {
        SqlConnection Cx;
        public Listado_Localidades()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Nueva_Localidad frm = new Nueva_Localidad();
            frm.ShowDialog();
            Carga_Datos();
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
                        CommandText = "Select * from View_Localidades Order by Localidad",
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

        private void ToolStripButtonEdita_Click(object sender, EventArgs e)
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
                MessageBox.Show("Debe de Seleccionar la Localidad que se quiere editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Listado_Localidades_Load(object sender, EventArgs e)
        {
            Carga_Datos();
        }

        private void toolStripButtonBorrar_Click(object sender, EventArgs e)
        {
            int Columna = 0;
            int Fila = 0;
            int Id_Localidad = 0;
            Fila = dataGridView1.CurrentCellAddress.Y;
            Id_Localidad = Int32.Parse(dataGridView1[Columna, Fila].Value.ToString());
            if (Id_Localidad == 0)
            {
                MessageBox.Show("Debe de Seleccionar la Localidad que se quiere Borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            CommandText = "Delete Localidades where Id_Localidad = @Id_Localidad"
                        };
                        Cmd.Parameters.AddWithValue("@Id_Localidad", Id_Localidad);
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
                    Carga_Datos();

                }
            }
        }
    }
}
