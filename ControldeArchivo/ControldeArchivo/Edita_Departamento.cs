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
    public partial class Edita_Departamento : Form
    {
        string _Departamento;
        int _IdDpto;
        SqlConnection Cx;
        public Edita_Departamento()
        {
            InitializeComponent();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Carga de Informacion

        public void Carga_Datos(Int32 Departamento)
        {
            _IdDpto = Departamento;

            using (Cx = new SqlConnection(Properties.Settings.Default.Cadena))
            {
                try
                {
                    Cx.Open();
                    SqlCommand Cmd = new SqlCommand
                    {
                        CommandType = CommandType.Text,
                        CommandText = "Select * from Departamentos where Id_Departamento = @Dpto"                                                
                    };
                    Cmd.Connection = Cx;
                    Cmd.Parameters.AddWithValue("@Dpto",Departamento);
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        #endregion

        #region Actualiza la Informacion en Base de Datos

        private void Actualiza()
        {
            string Dpto;
            Dpto = textBox_Departamento.Text;
            if (Dpto == "")
            {
                MessageBox.Show("Este dato es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _Departamento = textBox_Departamento.Text;
                using (Cx = new SqlConnection(Properties.Settings.Default.Cadena))
                {
                    try
                    {
                        Cx.Open();
                        SqlCommand Cmd = new SqlCommand
                        {
                            CommandType = CommandType.Text,
                            CommandText = "UPDATE Departamentos SET Departamento = @Departamento WHERE Id_Departamento = @ID"
                        };
                        Cmd.Connection = Cx;
                        Cmd.Parameters.AddWithValue("@Departamento", _Departamento);
                        Cmd.Parameters.AddWithValue("@ID", _IdDpto);
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
                    this.Close();
                }
            }

        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            Actualiza();
        }

        private void textBox_Departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Actualiza();
            }            
        }
        #endregion
    }
}
