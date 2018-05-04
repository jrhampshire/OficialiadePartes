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
    public partial class Edita_Fraccionamiento : Form
    {
        public int IDFraccTemp;

        public Edita_Fraccionamiento()
        {
            InitializeComponent();
        }

        public void CargaDatos(int ID,string Localidad, string Fracc)
        {
            IDFraccTemp = ID;
            SqlConnection Cx;
            using (Cx = new SqlConnection(Properties.Settings.Default.Cadena))
            {
                try
                {
                    Cx.Open();
                    SqlCommand Cmd = new SqlCommand
                    {
                        CommandType = CommandType.Text,
                        CommandText = "Select * from Localidades Order by Localidad",
                        Connection = Cx
                    };
                    SqlDataAdapter DA = new SqlDataAdapter(Cmd);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    comboBox_Localidad.DataSource = DT;
                    comboBox_Localidad.DisplayMember = "Localidad";
                    comboBox_Localidad.ValueMember = "Id_Localidad";
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
            comboBox_Localidad.SelectedText = Localidad;
            textBox_Fraccionamiento.Text = Fracc;
        }

        private void Edita_Fraccionamiento_Load(object sender, EventArgs e)
        {

        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            int Id_Localidad;
            string Fraccionamiento;
            bool Guardar;
            try { Id_Localidad = Convert.ToInt32(comboBox_Localidad.SelectedValue); }
            catch
            {
                MessageBox.Show("Este Dato es Obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fraccionamiento = textBox_Fraccionamiento.Text;
            if (Fraccionamiento == "")
            {
                MessageBox.Show("Este Dato es Obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Fraccionamiento.Focus();
                return;
            }
            SqlConnection Cx;
            SqlTransaction trans = null;
            using (Cx = new SqlConnection(Properties.Settings.Default.Cadena))
            {
                try
                {
                    Cx.Open();
                    using (SqlCommand Cmd = new SqlCommand())
                    {
                        Cmd.CommandType = CommandType.Text;
                        Cmd.CommandText = "Select count(Id_Localidad) from Fraccionamientos Where Id_Localidad = @Id and Nombre = @Nombre";
                        Cmd.Parameters.AddWithValue("@Id", Id_Localidad);
                        Cmd.Parameters.AddWithValue("@Nombre", Fraccionamiento);
                        Cmd.Connection = Cx;
                        Int32 Total = Convert.ToInt32(Cmd.ExecuteScalar());
                        Cmd.Dispose();
                        Cx.Close();
                        if (Total == 1)
                        {
                            Guardar = false;
                            MessageBox.Show("Ya existe un Fraccionamiento con este nombre en esta Localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Guardar = true;
                        }
                    }

                }
                catch (SqlException ex)
                {
                    if (trans != null) trans.Rollback();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Guardar == true)
                {
                    try
                    {
                        Cx.Open();
                        trans = Cx.BeginTransaction();
                        using (SqlCommand Cmd = new SqlCommand())
                        {
                            Cmd.Transaction = trans;
                            Cmd.CommandType = CommandType.Text;
                            Cmd.CommandText = "Update Fraccionamientos set Id_Localidad=@Id_Loc, Nombre=@Nombre Where id_Fraccionamiento = @ID";
                            Cmd.Parameters.AddWithValue("@ID", IDFraccTemp);
                            Cmd.Parameters.AddWithValue("@Id_Loc", Id_Localidad);
                            Cmd.Parameters.AddWithValue("@Nombre", Fraccionamiento);
                            Cmd.Connection = Cx;
                            Cmd.ExecuteNonQuery();
                        }
                        trans.Commit();
                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        if (trans != null) trans.Rollback();
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    this.Close();
                }

            }
        }
    }
}
