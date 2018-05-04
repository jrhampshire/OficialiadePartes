using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControldeArchivo
{
    public partial class Recepcion_Archivos : Form
    {
        SqlConnection Cx;
        public Recepcion_Archivos()
        {
            InitializeComponent();
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Actualiza();
            }
        }
        private void Actualiza()
        {
            string Barcode = textBox_Barcode.Text;
            string SQLStr = "Update Detalle_Prestamos set Fecha_Fin = GetDATE() Where Id_Documento = (Select Id_Documento from Documentos where Barcode = @Barcode) AND Fecha_Fin is null";
            SqlTransaction trans= null;
            using (Cx = new SqlConnection(Properties.Settings.Default.Cadena))
            {
                try
                {
                    Cx.Open();
                    trans = Cx.BeginTransaction();
                    using (SqlCommand Cmd = new SqlCommand())
                    {
                        Cmd.CommandType = CommandType.Text;
                        Cmd.CommandText = SQLStr;
                        Cmd.Parameters.AddWithValue(" @Barcode", Barcode);                 
                    }
                    trans.Commit();
                    textBox_Barcode.Text = "";
                    textBox_Barcode.Focus();
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

    }
}
