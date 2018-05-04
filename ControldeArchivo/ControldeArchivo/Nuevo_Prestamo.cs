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
    public partial class Nuevo_Prestamo : Form
    {
        public Nuevo_Prestamo()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string Solicitante_BarCode;
            string Autorizo_BarCode;
            Solicitante_BarCode = textBox_BarCodePersona.Text;
            Autorizo_BarCode = textBox_BarcodeAutorizo.Text;

            
             

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Busca();
            }
        }
        private void Busca()
        {
            //string Persona_BarCode;
            //string Persona_Nombre;
            //Persona_BarCode = "";
        }

        private void textBox_BarCodePersona_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_BarcodeDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                AgregaDoc();
            }
        }
        private void AgregaDoc()
        {
            string Documento_Actual;
            Documento_Actual = textBox_BarcodeDocumento.Text;
            string Localidad;
            string Fraccionamiento;
            string Manzana;
            string Lote;
            string ID;
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
                            Cmd.CommandText = "SELECT Documentos.Id_Documento, Localidades.Localidad, Fraccionamientos.Nombre AS Fraccionamiento, Documentos.Manzana, Documentos.Lote" +
                                " FROM Documentos INNER JOIN" +
                                " Fraccionamientos ON Documentos.Id_Fraccionamiento = Fraccionamientos.Id_Fraccionamiento INNER JOIN" +
                                " Localidades ON Fraccionamientos.Id_Localidad = Localidades.Id_Localidad" +
                                " WHERE(Documentos.Barcode = @BARCODE)";
                            Cmd.Parameters.AddWithValue("@BARCODE", Documento_Actual);
                            Cmd.Connection = Cx;
                            SqlDataReader Reader = Cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                if (Reader.HasRows)
                                {
                                    int TempID = Reader.GetInt32(0);
                                    ID = TempID.ToString();
                                    Localidad = Reader.GetString(1);
                                    Fraccionamiento = Reader.GetString(2);
                                    Manzana = Reader.GetString(3);
                                    Lote = Reader.GetString(4);
                                    string[] row = new string[] { ID, Localidad, Fraccionamiento, Manzana, Lote };
                                    dataGridView1.Rows.Add(row);
                                }
                            }
                            Reader.Close();

                        }
                    }
                    catch (SqlException e)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregaDoc();          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Aqui Borro del datagridview el producto no deseado
            Int32 rowToDelete = this.dataGridView1.Rows.GetFirstRow(
                DataGridViewElementStates.Selected);
            if (rowToDelete > -1)
            {
                this.dataGridView1.Rows.RemoveAt(rowToDelete);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selecciona_Solicitante frm = new Selecciona_Solicitante();
            frm.ShowDialog();

        }
    }
}
