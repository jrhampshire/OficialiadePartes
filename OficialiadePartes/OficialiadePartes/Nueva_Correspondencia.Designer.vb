﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_NuevoEmisor = New System.Windows.Forms.Button()
        Me.ComboBox_Remitente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_Oficio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_Observaciones = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_Documento = New System.Windows.Forms.TextBox()
        Me.Button_CargaDocumento = New System.Windows.Forms.Button()
        Me.Button_Cancelar = New System.Windows.Forms.Button()
        Me.Button_Aceptar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBoxNumOficio = New System.Windows.Forms.TextBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.ComboBox_Dependencia = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DateTimePicker.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox_Dependencia)
        Me.GroupBox1.Controls.Add(Me.Button_NuevoEmisor)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Remitente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 83)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Emisor"
        '
        'Button_NuevoEmisor
        '
        Me.Button_NuevoEmisor.Location = New System.Drawing.Point(426, 47)
        Me.Button_NuevoEmisor.Name = "Button_NuevoEmisor"
        Me.Button_NuevoEmisor.Size = New System.Drawing.Size(26, 23)
        Me.Button_NuevoEmisor.TabIndex = 2
        Me.Button_NuevoEmisor.Text = "..."
        Me.Button_NuevoEmisor.UseVisualStyleBackColor = True
        '
        'ComboBox_Remitente
        '
        Me.ComboBox_Remitente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Remitente.FormattingEnabled = True
        Me.ComboBox_Remitente.Location = New System.Drawing.Point(52, 49)
        Me.ComboBox_Remitente.Name = "ComboBox_Remitente"
        Me.ComboBox_Remitente.Size = New System.Drawing.Size(368, 21)
        Me.ComboBox_Remitente.TabIndex = 1
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
        Me.Label5.Location = New System.Drawing.Point(13, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Asunto del Oficio"
        '
        'TextBox_Oficio
        '
        Me.TextBox_Oficio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox_Oficio.Location = New System.Drawing.Point(107, 222)
        Me.TextBox_Oficio.Name = "TextBox_Oficio"
        Me.TextBox_Oficio.Size = New System.Drawing.Size(364, 20)
        Me.TextBox_Oficio.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Observaciones"
        '
        'TextBox_Observaciones
        '
        Me.TextBox_Observaciones.Location = New System.Drawing.Point(13, 262)
        Me.TextBox_Observaciones.Multiline = True
        Me.TextBox_Observaciones.Name = "TextBox_Observaciones"
        Me.TextBox_Observaciones.Size = New System.Drawing.Size(458, 97)
        Me.TextBox_Observaciones.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Destinatario(s)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 371)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Documento Digitalizado"
        '
        'TextBox_Documento
        '
        Me.TextBox_Documento.Location = New System.Drawing.Point(135, 368)
        Me.TextBox_Documento.Name = "TextBox_Documento"
        Me.TextBox_Documento.Size = New System.Drawing.Size(298, 20)
        Me.TextBox_Documento.TabIndex = 6
        '
        'Button_CargaDocumento
        '
        Me.Button_CargaDocumento.Location = New System.Drawing.Point(445, 366)
        Me.Button_CargaDocumento.Name = "Button_CargaDocumento"
        Me.Button_CargaDocumento.Size = New System.Drawing.Size(26, 23)
        Me.Button_CargaDocumento.TabIndex = 7
        Me.Button_CargaDocumento.Text = "..."
        Me.Button_CargaDocumento.UseVisualStyleBackColor = True
        '
        'Button_Cancelar
        '
        Me.Button_Cancelar.Location = New System.Drawing.Point(396, 395)
        Me.Button_Cancelar.Name = "Button_Cancelar"
        Me.Button_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Cancelar.TabIndex = 9
        Me.Button_Cancelar.Text = "Cancelar"
        Me.Button_Cancelar.UseVisualStyleBackColor = True
        '
        'Button_Aceptar
        '
        Me.Button_Aceptar.Location = New System.Drawing.Point(315, 395)
        Me.Button_Aceptar.Name = "Button_Aceptar"
        Me.Button_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Aceptar.TabIndex = 8
        Me.Button_Aceptar.Text = "Aceptar"
        Me.Button_Aceptar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = """Archivos PDF|*.pdf"""
        Me.OpenFileDialog1.Title = "Seleccione un archivo PDF"
        '
        'TextBoxNumOficio
        '
        Me.TextBoxNumOficio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxNumOficio.Location = New System.Drawing.Point(108, 16)
        Me.TextBoxNumOficio.Name = "TextBoxNumOficio"
        Me.TextBoxNumOficio.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNumOficio.TabIndex = 0
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(88, 122)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(383, 94)
        Me.CheckedListBox1.TabIndex = 14
        '
        'ComboBox_Dependencia
        '
        Me.ComboBox_Dependencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Dependencia.FormattingEnabled = True
        Me.ComboBox_Dependencia.Location = New System.Drawing.Point(84, 17)
        Me.ComboBox_Dependencia.Name = "ComboBox_Dependencia"
        Me.ComboBox_Dependencia.Size = New System.Drawing.Size(335, 21)
        Me.ComboBox_Dependencia.TabIndex = 3
        '
        'Nueva_Correspondencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 430)
        Me.ControlBox = False
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Button_Aceptar)
        Me.Controls.Add(Me.Button_Cancelar)
        Me.Controls.Add(Me.Button_CargaDocumento)
        Me.Controls.Add(Me.TextBox_Documento)
        Me.Controls.Add(Me.Label8)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox_Remitente As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_Oficio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_Observaciones As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_Documento As TextBox
    Friend WithEvents Button_CargaDocumento As Button
    Friend WithEvents Button_Cancelar As Button
    Friend WithEvents Button_Aceptar As Button
    Friend WithEvents Button_NuevoEmisor As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBoxNumOficio As TextBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents ComboBox_Dependencia As ComboBox
End Class
