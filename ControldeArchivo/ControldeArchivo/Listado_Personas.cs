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
    public partial class Listado_Personas : Form
    {
        SqlConnection Cx;
        public Listado_Personas()
        {
            InitializeComponent();
        }

        private void toolStripButton_Salir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void toolStripButton_Agrega_Click(object sender, EventArgs e)
        {
            Nueva_Persona frm = new Nueva_Persona();
            frm.ShowDialog();

        }
        private void Carga_Datos()
        {
            using(Cx = new SqlConnection(Properties.Settings.Default.Cadena))
            {
                try
                {
                    Cx.Open();
                    SqlCommand Cmd = new SqlCommand
                    {
                        CommandType = CommandType.Text,
                        CommandText = "Select * from View_ListadoPersonal Order by Nombre, Departamento",
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

        private void Listado_Personas_Load(object sender, EventArgs e)
        {
            Carga_Datos();
        }

        private void toolStripButton_Edita_Click(object sender, EventArgs e)
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
