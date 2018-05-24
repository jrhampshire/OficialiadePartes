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
        /// <summary>
        /// Busca en el DataGrid el ID Seleccionado, verifica que realmente haya seleccionado a una persona
        /// En caso afirmativo solicita la contraseña de verificacion 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                //Si existe la persona entonces solicita la contraseña de verificacion 
                string Pwd = "";
                Pwd = textBox_Pwd.Text;
                Pwd = Pwd.Trim();
                if (Pwd == "")
                {
                    MessageBox.Show("Este dato es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Pwd.Focus();
                    return;
                }
                else
                {

                }
            }
        }
    }
}
