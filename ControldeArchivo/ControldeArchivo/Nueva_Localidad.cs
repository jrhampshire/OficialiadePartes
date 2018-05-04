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
    public partial class Nueva_Localidad : Form
    {
        public Nueva_Localidad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            Guarda();
        }
        private void Guarda()
        {
            string _Localidad = textBox_Localidad.Text;
            SqlConnection Cx;
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
                        Cmd.CommandType = CommandType.Text ;
                        Cmd.CommandText = "INSERT INTO LOCALIDADES(LOCALIDAD) VALUES (@Localidad)";
                        Cmd.Parameters.AddWithValue("@Localidad",_Localidad);
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
            if ((int) e.KeyChar == (int)Keys.Enter)
            {
                Guarda();
            }
        }

        private void Nueva_Localidad_Load(object sender, EventArgs e)
        {

        }
    }
}
