namespace ControldeArchivo
{
    partial class Recepcion_Archivos
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
            this.textBox_Barcode = new System.Windows.Forms.TextBox();
            this.button_Salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // textBox_Barcode
            // 
            this.textBox_Barcode.Location = new System.Drawing.Point(143, 30);
            this.textBox_Barcode.Name = "textBox_Barcode";
            this.textBox_Barcode.Size = new System.Drawing.Size(156, 20);
            this.textBox_Barcode.TabIndex = 1;
            this.textBox_Barcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Barcode_KeyPress);
            // 
            // button_Salir
            // 
            this.button_Salir.Location = new System.Drawing.Point(224, 73);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(75, 23);
            this.button_Salir.TabIndex = 2;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ControldeArchivo.Properties.Resources.Barcode;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Recepcion_Archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 108);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.textBox_Barcode);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(329, 147);
            this.MinimumSize = new System.Drawing.Size(329, 147);
            this.Name = "Recepcion_Archivos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepcion de Archivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Barcode;
        private System.Windows.Forms.Button button_Salir;
    }
}