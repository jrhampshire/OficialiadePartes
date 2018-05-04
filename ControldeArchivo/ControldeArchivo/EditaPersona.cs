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
    public partial class EditaPersona : Form
    {
        SqlConnection Cx;
        int ID;

        public EditaPersona()
        {
            InitializeComponent();
        }

        private void EditaPersona_Load(object sender, EventArgs e)
        {
            CargaDptos();
        }

        private void CargaDptos()
        {
            SqlConnection Cx;
            using (Cx=new SqlConnection(Properties.Settings.Default.Cadena))
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
        
        internal void CargaDatos(int Id_Persona)
        {
            ID = Id_Persona;
            SqlConnection Cx;
            try
            {
                using (Cx = new SqlConnection(Properties.Settings.Default.Cadena))
                {
                    SqlTransaction trans = null;
                    try
                    {
                        Cx.Open();
                        trans = Cx.BeginTransaction();
                        using (SqlCommand Cmd = new SqlCommand())
                        {
                            Cmd.Transaction = trans;
                            Cmd.CommandType = CommandType.Text;
                            Cmd.CommandText = "Select Id_Departamento, Nombre, BarCode, Permisos from Personal Where Id_Personal = @ID";
                            Cmd.Parameters.AddWithValue("@ID", ID);
                            Cmd.Connection = Cx;
                            SqlDataReader Lector = Cmd.ExecuteReader();
                            while (Lector.Read())
                            {
                                if (Lector.HasRows)
                                {
                                    this.comboBox_Departamento.SelectedValue = Lector.GetInt32(0);
                                    this.textBox_Nombre.Text = Lector.GetString(1);
                                    this.textBox_BarCode.Text= Lector.GetString(2);
                                    string Permisos = Lector.GetString(3);
                                    if (Permisos == "Administrador")
                                    {
                                        radioButton1.Checked = true;
                                    }
                                    else
                                    {
                                        radioButton2.Checked = true;
                                    }
                                }
                            }
                            Lector.Close();
                        }
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (Cx.State == ConnectionState.Open)
                        {
                            Cx.Close();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string _Nombre;
            string _Permisos = "";
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
                                    CommandText = "Update Personal set Nombre = @Nombre, Id_Departamento = @Id_Departamento, Permisos = @Permisos, BarCode = @BarCode Where Id_Personal = @ID",
                                    Connection = Cx
                                };
                                Cmd.Parameters.AddWithValue("@ID", ID);
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
    }
}
