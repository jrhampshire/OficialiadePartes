<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Correspondencia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.Button_Edita = New System.Windows.Forms.ToolStripButton()
        Me.Button_Correo = New System.Windows.Forms.ToolStripButton()
        Me.Button_PDF = New System.Windows.Forms.ToolStripButton()
        Me.Button_Borrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.GroupBox1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(944, 556)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(944, 595)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(920, 541)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Correspondencia Recibida"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nuevo, Me.Button_Edita, Me.Button_Correo, Me.Button_PDF, Me.Button_Borrar, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripButton3, Me.ToolStripSeparator2, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(559, 39)
        Me.ToolStrip1.TabIndex = 0
        '
        'Nuevo
        '
        Me.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Nuevo.Image = Global.OficialiadePartes.My.Resources.Resources.Add_32x32
        Me.Nuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(36, 36)
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.ToolTipText = "Nuevo"
        '
        'Button_Edita
        '
        Me.Button_Edita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Edita.Image = Global.OficialiadePartes.My.Resources.Resources.Edit_32x32
        Me.Button_Edita.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Button_Edita.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Edita.Name = "Button_Edita"
        Me.Button_Edita.Size = New System.Drawing.Size(36, 36)
        Me.Button_Edita.Text = "Editar"
        '
        'Button_Correo
        '
        Me.Button_Correo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Correo.Image = Global.OficialiadePartes.My.Resources.Resources.Forward_32x32
        Me.Button_Correo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Button_Correo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Correo.Name = "Button_Correo"
        Me.Button_Correo.Size = New System.Drawing.Size(36, 36)
        Me.Button_Correo.Text = "Reenviar Correo"
        '
        'Button_PDF
        '
        Me.Button_PDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_PDF.Image = Global.OficialiadePartes.My.Resources.Resources.Adobe_32x32
        Me.Button_PDF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Button_PDF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_PDF.Name = "Button_PDF"
        Me.Button_PDF.Size = New System.Drawing.Size(36, 36)
        Me.Button_PDF.Text = "ToolStripButton6"
        '
        'Button_Borrar
        '
        Me.Button_Borrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Borrar.Image = Global.OficialiadePartes.My.Resources.Resources.Delete_32x32
        Me.Button_Borrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Button_Borrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Borrar.Name = "Button_Borrar"
        Me.Button_Borrar.Size = New System.Drawing.Size(36, 36)
        Me.Button_Borrar.Text = "Borrar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(250, 39)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.OficialiadePartes.My.Resources.Resources.Search_32x32
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton3.Text = "Buscar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.OficialiadePartes.My.Resources.Resources.Log_Out_32x32
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton5.Text = "Exit"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(914, 522)
        Me.DataGridView1.TabIndex = 0
        '
        'Correspondencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 595)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "Correspondencia"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Correspondencia"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Nuevo As ToolStripButton
    Friend WithEvents Button_Edita As ToolStripButton
    Friend WithEvents Button_Borrar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents Button_Correo As ToolStripButton
    Friend WithEvents Button_PDF As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
End Class
