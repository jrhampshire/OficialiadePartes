using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControldeArchivo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_Localidades frm = new Listado_Localidades();
            frm.ShowDialog();

        }

        private void fraccionamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_Fraccionamientos frm = new Listado_Fraccionamientos();
            frm.ShowDialog();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void prestamoDeExpedientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_Prestamos frm = new Listado_Prestamos();
            frm.ShowDialog();
        }
    }
}
