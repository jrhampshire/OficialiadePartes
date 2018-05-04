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
    
    public partial class Edita_Localidad : Form
    {
        private int ID = 0;

        public Edita_Localidad()
        {
            InitializeComponent();
        }

        private void Edita_Localidad_Load(object sender, EventArgs e)
        {

        }       

        internal void CargaDatos(int Id_Localidad)
        {
            ID = Id_Localidad;
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
                            Cmd.CommandText = "Select Localidad from Localidades Where Id_Localidad = @ID";
                            Cmd.Parameters.AddWithValue("@ID", ID);
                            Cmd.Connection = Cx;
                            SqlDataReader Lector = Cmd.ExecuteReader();
                            while (Lector.Read())
                            {
                                if (Lector.HasRows)
                                {
                                    this.textBox_Localidad.Text = Lector.GetString(0);
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

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            Actualiza();            
        }

        private void Actualiza()
        {
        string Localidad = this.textBox_Localidad.Text;
        SqlConnection Cx;
            using (Cx = new SqlConnection(Properties.Settings.Default.Cadena))
            {
                string LocalidadTemp;
                LocalidadTemp = textBox_Localidad.Text;
                SqlTransaction trans = null;

                try
                {
                    Cx.Open();
                    trans = Cx.BeginTransaction();
                    using (SqlCommand Cmd = new SqlCommand())
                    {
                        Cmd.Transaction = trans;
                        Cmd.CommandType = CommandType.Text;
                        Cmd.CommandText = "Update Localidades Set Localidad = @Localidad where Id_Localidad = @Id_Localidad";
                        Cmd.Parameters.AddWithValue("@Id_Localidad", ID);
                        Cmd.Parameters.AddWithValue("@Localidad", LocalidadTemp);
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
        }

        private void textBox_Localidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Actualiza();
            }
        }
    }
}
