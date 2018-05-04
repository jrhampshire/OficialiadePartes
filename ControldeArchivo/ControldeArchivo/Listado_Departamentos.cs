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
    public partial class Listado_Departamentos : Form
    {
        SqlConnection Cx;

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
                        CommandText = "Select Id_Departamento as ID, Departamento from Departamentos Order by Departamento",
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

        public Listado_Departamentos()
        {
            InitializeComponent();
        }

        private void toolStripButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonBorrar_Click(object sender, EventArgs e)
        {
            int Columna = 0;
            int Fila = 0;
            int Id_Departamento = 0;
            Fila = dataGridView1.CurrentCellAddress.Y;
            Id_Departamento = Int32.Parse(dataGridView1[Columna, Fila].Value.ToString());
            if (Id_Departamento == 0)
            {
                MessageBox.Show("Debe de Seleccionar el Departamento que se quiere Borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            CommandText = "Delete Departamentos where Id_Departamento = @Id_Departamento"
                        };
                        Cmd.Parameters.AddWithValue("@Id_Departamento", Id_Departamento);
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Nuevo_Departamento frm = new Nuevo_Departamento();
            frm.ShowDialog();
            Carga_Datos();

        }

        private void toolStripButtonEdita_Click(object sender, EventArgs e)
        {
            int Columna = 0;
            int Fila = 0;
            int Id_Departamento = 0;
            Fila = dataGridView1.CurrentCellAddress.Y;
            Id_Departamento = Int32.Parse(dataGridView1[Columna, Fila].Value.ToString());
            if (Id_Departamento == 0)
            {
                MessageBox.Show("Debe de Seleccionar el Departamento que se quiere Borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
             
            }

        }
    }
}
