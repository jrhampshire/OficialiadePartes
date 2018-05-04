namespace ControldeArchivo
{
    partial class Listado_Prestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Button_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.Button_RecibeArchivo = new System.Windows.Forms.ToolStripButton();
            this.Button_Buscar = new System.Windows.Forms.ToolStripButton();
            this.Button_Exportar = new System.Windows.Forms.ToolStripButton();
            this.Button_Salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(969, 522);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(969, 547);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(969, 522);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_Nuevo,
            this.Button_RecibeArchivo,
            this.toolStripTextBox1,
            this.Button_Buscar,
            this.Button_Exportar,
            this.toolStripSeparator1,
            this.Button_Salir});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(335, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 25);
            this.toolStripTextBox1.ToolTipText = "Buscar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Button_Nuevo
            // 
            this.Button_Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Nuevo.Image = global::ControldeArchivo.Properties.Resources.Add_16x16;
            this.Button_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Nuevo.Name = "Button_Nuevo";
            this.Button_Nuevo.Size = new System.Drawing.Size(23, 22);
            this.Button_Nuevo.Text = "Nuevo";
            this.Button_Nuevo.ToolTipText = "Nuevo";
            // 
            // Button_RecibeArchivo
            // 
            this.Button_RecibeArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_RecibeArchivo.Image = global::ControldeArchivo.Properties.Resources.file_manager_16x16;
            this.Button_RecibeArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_RecibeArchivo.Name = "Button_RecibeArchivo";
            this.Button_RecibeArchivo.Size = new System.Drawing.Size(23, 22);
            this.Button_RecibeArchivo.Text = "Recibe Archivo";
            this.Button_RecibeArchivo.Click += new System.EventHandler(this.Button_Edita_Click);
            // 
            // Button_Buscar
            // 
            this.Button_Buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Buscar.Image = global::ControldeArchivo.Properties.Resources.Search_16x16;
            this.Button_Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Buscar.Name = "Button_Buscar";
            this.Button_Buscar.Size = new System.Drawing.Size(23, 22);
            this.Button_Buscar.Text = "Buscar";
            // 
            // Button_Exportar
            // 
            this.Button_Exportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Exportar.Image = global::ControldeArchivo.Properties.Resources.Excel_32x32;
            this.Button_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Exportar.Name = "Button_Exportar";
            this.Button_Exportar.Size = new System.Drawing.Size(23, 22);
            this.Button_Exportar.Text = "Exportar a Excel";
            // 
            // Button_Salir
            // 
            this.Button_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Salir.Image = global::ControldeArchivo.Properties.Resources.Log_Out_16x16;
            this.Button_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Salir.Name = "Button_Salir";
            this.Button_Salir.Size = new System.Drawing.Size(23, 22);
            this.Button_Salir.Text = "Salir";
            this.Button_Salir.Click += new System.EventHandler(this.Button_Salir_Click);
            // 
            // Listado_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 547);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Listado_Prestamos";
            this.Text = "Listado de Prestamos";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Button_Nuevo;
        private System.Windows.Forms.ToolStripButton Button_RecibeArchivo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Button_Salir;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton Button_Buscar;
        private System.Windows.Forms.ToolStripButton Button_Exportar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}