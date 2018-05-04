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
    public partial class Nuevo_Departamento : Form
    {
        SqlConnection Cx;
        public Nuevo_Departamento()
        {
            InitializeComponent();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Guarda Datos

        private void GuardaDatos()
        {
            string _Departamento;
            _Departamento = textBox_Departamento.Text;
            if (_Departamento == "")
            {
                MessageBox.Show("Este dato es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Departamento.Focus();
                return;
            }
            else
            {
                using (Cx = new SqlConnection(Properties.Settings.Default.Cadena))
                {
                    try
                    {
                        Cx.Open();
                        SqlCommand Cmd = new SqlCommand
                        {
                            CommandType = CommandType.Text,
                            CommandText = "Insert into Departamentos(Departamento) Values (@Departamento)",
                            Connection = Cx
                        };
                        Cmd.Parameters.AddWithValue("@Departamento", _Departamento);
                        Cmd.ExecuteNonQuery();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                this.Close();
            }
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            GuardaDatos();
        }

        private void textBox_Departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                GuardaDatos();
            }
        }
        #endregion
    }
}
