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
using BarcodeLib;
namespace ControldeArchivo
{
    public partial class Nueva_Persona : Form
    {
        SqlConnection Cx;
        public Nueva_Persona()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string _Nombre;
            string _Permisos="";
            int _Id_Departamento = 0;
            string _BarCode = "";
            if (radioButton1.Checked == true)
            {
                _Permisos = "Administrador";
            }
            if (radioButton2.Checked == true)
            {
                _Permisos = "Usuario";
            }
            _Nombre = textBox_Nombre.Text.Trim();
            _BarCode = textBox_BarCode.Text.Trim();
            if (_Nombre == "")
            {
                MessageBox.Show("Este dato es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Nombre.Focus();
                return;
            }
            else
            {
                if (_BarCode == "")
                {
                    MessageBox.Show("Este dato es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_BarCode.Focus();
                    return;
                }
                else
                {
                    try
                    {
                        _Id_Departamento = Convert.ToInt32(comboBox_Departamento.SelectedValue);
                    }
                    catch
                    {
                        MessageBox.Show("A ocurrido un error al momento de intentar leer el Departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    try
                    {
                        using (Cx = new SqlConnection(Properties.Settings.Default.Cadena))
                        {
                            try
                            {
                                Cx.Open();
                                SqlCommand Cmd = new SqlCommand
                                {
                                    CommandType = CommandType.Text,
                                    CommandText = "Insert into Personal(Nombre, Id_Departamento, Permisos, BarCode) Values (@Nombre, @Id_Departamento, @Permisos, @BarCode)",
                                    Connection = Cx
                                };
                                Cmd.Parameters.AddWithValue("@Nombre", _Nombre);
                                Cmd.Parameters.AddWithValue("@Id_Departamento", _Id_Departamento);
                                Cmd.Parameters.AddWithValue("@Permisos", _Permisos);
                                Cmd.Parameters.AddWithValue("@BarCode", _BarCode);
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nueva_Persona_Load(object sender, EventArgs e)
        {
            CargaDptos();
        }

        private void CargaDptos()
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
                        CommandText = "Select * from Departementos Order by Departamento",
                        Connection = Cx
                    };
                    SqlDataAdapter DA = new SqlDataAdapter(Cmd);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    comboBox_Departamento.DataSource = DT;
                    comboBox_Departamento.DisplayMember = "Departamento";
                    comboBox_Departamento.ValueMember = "Id_Departamento";
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

        }
    }
}
