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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker_FechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker_FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_Reload = New System.Windows.Forms.ToolStripButton()
        Me.Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.Button_Correo = New System.Windows.Forms.ToolStripButton()
        Me.Button_PDF = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_Exportar = New System.Windows.Forms.ToolStripButton()
        Me.Button_Borrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_FechaFin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_FechaInicio)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(938, 550)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha de Fin"
        '
        'DateTimePicker_FechaFin
        '
        Me.DateTimePicker_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_FechaFin.Location = New System.Drawing.Point(287, 14)
        Me.DateTimePicker_FechaFin.Name = "DateTimePicker_FechaFin"
        Me.DateTimePicker_FechaFin.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker_FechaFin.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha de Inicio"
        '
        'DateTimePicker_FechaInicio
        '
        Me.DateTimePicker_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_FechaInicio.Location = New System.Drawing.Point(95, 14)
        Me.DateTimePicker_FechaInicio.Name = "DateTimePicker_FechaInicio"
        Me.DateTimePicker_FechaInicio.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker_FechaInicio.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(923, 498)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Correspondencia Recibida"
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
        Me.DataGridView1.Size = New System.Drawing.Size(917, 479)
        Me.DataGridView1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Reload, Me.Nuevo, Me.Button_Correo, Me.Button_PDF, Me.ToolStripButton_Exportar, Me.Button_Borrar, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripButton3, Me.ToolStripSeparator2, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(595, 39)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton_Reload
        '
        Me.ToolStripButton_Reload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Reload.Image = Global.OficialiadePartes.My.Resources.Resources.Refresh_32x32
        Me.ToolStripButton_Reload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton_Reload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Reload.Name = "ToolStripButton_Reload"
        Me.ToolStripButton_Reload.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton_Reload.Text = "Volver a Cargar Informacion"
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
        Me.Button_PDF.Text = "Abrir PDF"
        '
        'ToolStripButton_Exportar
        '
        Me.ToolStripButton_Exportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton_Exportar.Image = Global.OficialiadePartes.My.Resources.Resources.Excel_32x32
        Me.ToolStripButton_Exportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Exportar.Name = "ToolStripButton_Exportar"
        Me.ToolStripButton_Exportar.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton_Exportar.Text = "Exportar a Excel"
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
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Nuevo As ToolStripButton
    Friend WithEvents Button_Borrar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents Button_Correo As ToolStripButton
    Friend WithEvents Button_PDF As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker_FechaFin As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker_FechaInicio As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStripButton_Reload As ToolStripButton
    Friend WithEvents ToolStripButton_Exportar As ToolStripButton
End Class
