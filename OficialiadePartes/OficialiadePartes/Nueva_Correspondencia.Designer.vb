<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nueva_Correspondencia
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
        Me.TextBoxNumOficio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_NuevoEmisor = New System.Windows.Forms.Button()
        Me.ComboBox_Remitente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox_Dependencia = New System.Windows.Forms.ComboBox()
        Me.DependenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CorrespondenciaDataSet = New OficialiadePartes.CorrespondenciaDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_Oficio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_Observaciones = New System.Windows.Forms.TextBox()
        Me.ComboBox_Destinatario = New System.Windows.Forms.ComboBox()
        Me.PersonasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_Documento = New System.Windows.Forms.TextBox()
        Me.Button_CargaDocumento = New System.Windows.Forms.Button()
        Me.Button_Cancelar = New System.Windows.Forms.Button()
        Me.Button_Aceptar = New System.Windows.Forms.Button()
        Me.DependenciasTableAdapter = New OficialiadePartes.CorrespondenciaDataSetTableAdapters.DependenciasTableAdapter()
        Me.PersonasTableAdapter = New OficialiadePartes.CorrespondenciaDataSetTableAdapters.PersonasTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DependenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CorrespondenciaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxNumOficio
        '
        Me.TextBoxNumOficio.Location = New System.Drawing.Point(108, 16)
        Me.TextBoxNumOficio.Name = "TextBoxNumOficio"
        Me.TextBoxNumOficio.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNumOficio.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número de Oficio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(271, 15)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_NuevoEmisor)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Remitente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Dependencia)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 83)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Emisor"
        '
        'Button_NuevoEmisor
        '
        Me.Button_NuevoEmisor.Location = New System.Drawing.Point(426, 47)
        Me.Button_NuevoEmisor.Name = "Button_NuevoEmisor"
        Me.Button_NuevoEmisor.Size = New System.Drawing.Size(26, 23)
        Me.Button_NuevoEmisor.TabIndex = 16
        Me.Button_NuevoEmisor.Text = "..."
        Me.Button_NuevoEmisor.UseVisualStyleBackColor = True
        '
        'ComboBox_Remitente
        '
        Me.ComboBox_Remitente.FormattingEnabled = True
        Me.ComboBox_Remitente.Location = New System.Drawing.Point(52, 49)
        Me.ComboBox_Remitente.Name = "ComboBox_Remitente"
        Me.ComboBox_Remitente.Size = New System.Drawing.Size(368, 21)
        Me.ComboBox_Remitente.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nombre"
        '
        'ComboBox_Dependencia
        '
        Me.ComboBox_Dependencia.DataSource = Me.DependenciasBindingSource
        Me.ComboBox_Dependencia.DisplayMember = "Dependencia"
        Me.ComboBox_Dependencia.FormattingEnabled = True
        Me.ComboBox_Dependencia.Location = New System.Drawing.Point(84, 17)
        Me.ComboBox_Dependencia.Name = "ComboBox_Dependencia"
        Me.ComboBox_Dependencia.Size = New System.Drawing.Size(368, 21)
        Me.ComboBox_Dependencia.TabIndex = 1
        Me.ComboBox_Dependencia.ValueMember = "Id_Dependencia"
        '
        'DependenciasBindingSource
        '
        Me.DependenciasBindingSource.DataMember = "Dependencias"
        Me.DependenciasBindingSource.DataSource = Me.CorrespondenciaDataSet
        '
        'CorrespondenciaDataSet
        '
        Me.CorrespondenciaDataSet.DataSetName = "CorrespondenciaDataSet"
        Me.CorrespondenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Dependencia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Asunto del Oficio"
        '
        'TextBox_Oficio
        '
        Me.TextBox_Oficio.Location = New System.Drawing.Point(107, 173)
        Me.TextBox_Oficio.Name = "TextBox_Oficio"
        Me.TextBox_Oficio.Size = New System.Drawing.Size(364, 20)
        Me.TextBox_Oficio.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Observaciones"
        '
        'TextBox_Observaciones
        '
        Me.TextBox_Observaciones.Location = New System.Drawing.Point(13, 224)
        Me.TextBox_Observaciones.Multiline = True
        Me.TextBox_Observaciones.Name = "TextBox_Observaciones"
        Me.TextBox_Observaciones.Size = New System.Drawing.Size(458, 97)
        Me.TextBox_Observaciones.TabIndex = 8
        '
        'ComboBox_Destinatario
        '
        Me.ComboBox_Destinatario.DataSource = Me.PersonasBindingSource
        Me.ComboBox_Destinatario.DisplayMember = "Persona"
        Me.ComboBox_Destinatario.FormattingEnabled = True
        Me.ComboBox_Destinatario.Location = New System.Drawing.Point(82, 139)
        Me.ComboBox_Destinatario.Name = "ComboBox_Destinatario"
        Me.ComboBox_Destinatario.Size = New System.Drawing.Size(389, 21)
        Me.ComboBox_Destinatario.TabIndex = 12
        '
        'PersonasBindingSource
        '
        Me.PersonasBindingSource.DataMember = "Personas"
        Me.PersonasBindingSource.DataSource = Me.CorrespondenciaDataSet
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Destinatario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 333)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Documento Digitalizado"
        '
        'TextBox_Documento
        '
        Me.TextBox_Documento.Location = New System.Drawing.Point(135, 330)
        Me.TextBox_Documento.Name = "TextBox_Documento"
        Me.TextBox_Documento.Size = New System.Drawing.Size(298, 20)
        Me.TextBox_Documento.TabIndex = 14
        '
        'Button_CargaDocumento
        '
        Me.Button_CargaDocumento.Location = New System.Drawing.Point(445, 328)
        Me.Button_CargaDocumento.Name = "Button_CargaDocumento"
        Me.Button_CargaDocumento.Size = New System.Drawing.Size(26, 23)
        Me.Button_CargaDocumento.TabIndex = 15
        Me.Button_CargaDocumento.Text = "..."
        Me.Button_CargaDocumento.UseVisualStyleBackColor = True
        '
        'Button_Cancelar
        '
        Me.Button_Cancelar.Location = New System.Drawing.Point(396, 357)
        Me.Button_Cancelar.Name = "Button_Cancelar"
        Me.Button_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Cancelar.TabIndex = 16
        Me.Button_Cancelar.Text = "Cancelar"
        Me.Button_Cancelar.UseVisualStyleBackColor = True
        '
        'Button_Aceptar
        '
        Me.Button_Aceptar.Location = New System.Drawing.Point(315, 357)
        Me.Button_Aceptar.Name = "Button_Aceptar"
        Me.Button_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Aceptar.TabIndex = 17
        Me.Button_Aceptar.Text = "Aceptar"
        Me.Button_Aceptar.UseVisualStyleBackColor = True
        '
        'DependenciasTableAdapter
        '
        Me.DependenciasTableAdapter.ClearBeforeFill = True
        '
        'PersonasTableAdapter
        '
        Me.PersonasTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = """Archivos PDF|*.pdf"""
        Me.OpenFileDialog1.Title = "Seleccione un archivo PDF"
        '
        'Nueva_Correspondencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_Aceptar)
        Me.Controls.Add(Me.Button_Cancelar)
        Me.Controls.Add(Me.Button_CargaDocumento)
        Me.Controls.Add(Me.TextBox_Documento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox_Destinatario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox_Observaciones)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox_Oficio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxNumOficio)
        Me.Name = "Nueva_Correspondencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Oficio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DependenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CorrespondenciaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNumOficio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox_Remitente As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox_Dependencia As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_Oficio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_Observaciones As TextBox
    Friend WithEvents ComboBox_Destinatario As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_Documento As TextBox
    Friend WithEvents Button_CargaDocumento As Button
    Friend WithEvents Button_Cancelar As Button
    Friend WithEvents Button_Aceptar As Button
    Friend WithEvents Button_NuevoEmisor As Button
    Friend WithEvents CorrespondenciaDataSet As CorrespondenciaDataSet
    Friend WithEvents DependenciasBindingSource As BindingSource
    Friend WithEvents DependenciasTableAdapter As CorrespondenciaDataSetTableAdapters.DependenciasTableAdapter
    Friend WithEvents PersonasBindingSource As BindingSource
    Friend WithEvents PersonasTableAdapter As CorrespondenciaDataSetTableAdapters.PersonasTableAdapter
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
