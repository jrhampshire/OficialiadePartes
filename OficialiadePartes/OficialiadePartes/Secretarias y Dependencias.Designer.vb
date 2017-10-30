<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Secretarias_y_Dependencias
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DependenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button_Borrar = New System.Windows.Forms.Button()
        Me.Button_Agregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.Button_Salir = New System.Windows.Forms.Button()
        Me.CorrespondenciaDataSet2 = New OficialiadePartes.CorrespondenciaDataSet()
        Me.DependenciasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DependenciasTableAdapter2 = New OficialiadePartes.CorrespondenciaDataSetTableAdapters.DependenciasTableAdapter()
        CType(Me.DependenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CorrespondenciaDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DependenciasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dependencia"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DependenciasBindingSource2
        Me.ComboBox1.DisplayMember = "Dependencia"
        Me.ComboBox1.Location = New System.Drawing.Point(90, 10)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(502, 21)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.ValueMember = "Id_Dependencia"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(598, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_email)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Button_Borrar)
        Me.GroupBox1.Controls.Add(Me.Button_Agregar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox_Nombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(611, 343)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal"
        '
        'TextBox_email
        '
        Me.TextBox_email.Location = New System.Drawing.Point(56, 42)
        Me.TextBox_email.Name = "TextBox_email"
        Me.TextBox_email.Size = New System.Drawing.Size(383, 20)
        Me.TextBox_email.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "email"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(592, 271)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(586, 252)
        Me.DataGridView1.TabIndex = 0
        '
        'Button_Borrar
        '
        Me.Button_Borrar.Location = New System.Drawing.Point(523, 40)
        Me.Button_Borrar.Name = "Button_Borrar"
        Me.Button_Borrar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Borrar.TabIndex = 3
        Me.Button_Borrar.Text = "Borrar"
        Me.Button_Borrar.UseVisualStyleBackColor = True
        '
        'Button_Agregar
        '
        Me.Button_Agregar.Location = New System.Drawing.Point(442, 40)
        Me.Button_Agregar.Name = "Button_Agregar"
        Me.Button_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Agregar.TabIndex = 2
        Me.Button_Agregar.Text = "Agregar"
        Me.Button_Agregar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.Location = New System.Drawing.Point(56, 16)
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.Size = New System.Drawing.Size(383, 20)
        Me.TextBox_Nombre.TabIndex = 0
        '
        'Button_Salir
        '
        Me.Button_Salir.Location = New System.Drawing.Point(550, 386)
        Me.Button_Salir.Name = "Button_Salir"
        Me.Button_Salir.Size = New System.Drawing.Size(75, 23)
        Me.Button_Salir.TabIndex = 3
        Me.Button_Salir.Text = "Salir"
        Me.Button_Salir.UseVisualStyleBackColor = True
        '
        'CorrespondenciaDataSet2
        '
        Me.CorrespondenciaDataSet2.DataSetName = "CorrespondenciaDataSet"
        Me.CorrespondenciaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DependenciasBindingSource2
        '
        Me.DependenciasBindingSource2.DataMember = "Dependencias"
        Me.DependenciasBindingSource2.DataSource = Me.CorrespondenciaDataSet2
        '
        'DependenciasTableAdapter2
        '
        Me.DependenciasTableAdapter2.ClearBeforeFill = True
        '
        'Secretarias_y_Dependencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 421)
        Me.Controls.Add(Me.Button_Salir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Secretarias_y_Dependencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Secretarias y Dependencias"
        CType(Me.DependenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CorrespondenciaDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DependenciasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button_Borrar As Button
    Friend WithEvents Button_Agregar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Nombre As TextBox
    Friend WithEvents TextBox_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_Salir As Button
    Friend WithEvents CorrespondenciaDataSet As CorrespondenciaDataSet
    Friend WithEvents DependenciasBindingSource As BindingSource
    Friend WithEvents DependenciasTableAdapter As CorrespondenciaDataSetTableAdapters.DependenciasTableAdapter
    Friend WithEvents CorrespondenciaDataSet1BindingSource As BindingSource
    Friend WithEvents CorrespondenciaDataSet1 As CorrespondenciaDataSet
    Friend WithEvents DependenciasBindingSource1 As BindingSource
    Friend WithEvents DependenciasTableAdapter1 As CorrespondenciaDataSetTableAdapters.DependenciasTableAdapter
    Friend WithEvents CorrespondenciaDataSet2 As CorrespondenciaDataSet
    Friend WithEvents DependenciasBindingSource2 As BindingSource
    Friend WithEvents DependenciasTableAdapter2 As CorrespondenciaDataSetTableAdapters.DependenciasTableAdapter
End Class
