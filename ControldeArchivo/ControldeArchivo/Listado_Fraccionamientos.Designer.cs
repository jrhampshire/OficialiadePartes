namespace ControldeArchivo
{
    partial class Listado_Fraccionamientos
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
            this.toolStripButton_Agrega = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Edita = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Borrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Salir = new System.Windows.Forms.ToolStripButton();
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(568, 342);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(568, 367);
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
            this.dataGridView1.Size = new System.Drawing.Size(568, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Agrega,
            this.toolStripButton_Edita,
            this.toolStripButton_Borrar,
            this.toolStripSeparator1,
            this.toolStripButton_Salir});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(141, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton_Agrega
            // 
            this.toolStripButton_Agrega.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Agrega.Image = global::ControldeArchivo.Properties.Resources.Add_16x16;
            this.toolStripButton_Agrega.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Agrega.Name = "toolStripButton_Agrega";
            this.toolStripButton_Agrega.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Agrega.Text = "toolStripButton1";
            this.toolStripButton_Agrega.Click += new System.EventHandler(this.toolStripButton_Agrega_Click);
            // 
            // toolStripButton_Edita
            // 
            this.toolStripButton_Edita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Edita.Image = global::ControldeArchivo.Properties.Resources.Edit_16x16;
            this.toolStripButton_Edita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Edita.Name = "toolStripButton_Edita";
            this.toolStripButton_Edita.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Edita.Text = "toolStripButton2";
            this.toolStripButton_Edita.Click += new System.EventHandler(this.toolStripButton_Edita_Click);
            // 
            // toolStripButton_Borrar
            // 
            this.toolStripButton_Borrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Borrar.Image = global::ControldeArchivo.Properties.Resources.Delete_16x16;
            this.toolStripButton_Borrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Borrar.Name = "toolStripButton_Borrar";
            this.toolStripButton_Borrar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Borrar.Text = "toolStripButton3";
            this.toolStripButton_Borrar.Click += new System.EventHandler(this.toolStripButton_Borrar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Salir
            // 
            this.toolStripButton_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Salir.Image = global::ControldeArchivo.Properties.Resources.Log_Out_16x16;
            this.toolStripButton_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Salir.Name = "toolStripButton_Salir";
            this.toolStripButton_Salir.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Salir.Text = "toolStripButton4";
            this.toolStripButton_Salir.Click += new System.EventHandler(this.toolStripButton_Salir_Click);
            // 
            // Listado_Fraccionamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 367);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Listado_Fraccionamientos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Fraccionamientos";
            this.Load += new System.EventHandler(this.Listado_Fraccionamientos_Load);
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
        private System.Windows.Forms.ToolStripButton toolStripButton_Agrega;
        private System.Windows.Forms.ToolStripButton toolStripButton_Edita;
        private System.Windows.Forms.ToolStripButton toolStripButton_Borrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Salir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}