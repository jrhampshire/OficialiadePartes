Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.IO.Compression
Imports System.Net.Mail


Public Class Nueva_Correspondencia
    Dim SQL_Str As String = Nothing
    Dim Cx As New SqlConnection(My.Settings.Cadena)
    Dim _Oficio As New Oficio
    Dim Dependencias_Cargadas As Boolean = False

    Private Sub Nueva_Correspondencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: esta línea de código carga datos en la tabla 'CorrespondenciaDataSet.Personas' Puede moverla o quitarla según sea necesario.
        'Me.PersonasTableAdapter.Fill(Me.CorrespondenciaDataSet.Personas)
        ''TODO: esta línea de código carga datos en la tabla 'CorrespondenciaDataSet.Dependencias' Puede moverla o quitarla según sea necesario.
        'Me.DependenciasTableAdapter.Fill(Me.CorrespondenciaDataSet.Dependencias)
        Carga_Datos_Dependencias()
        Carga_Datos_EmpleadosPromo()
    End Sub
    Sub Carga_Datos_Dependencias()
        Try
            SQL_Str = "Select Id_Dependencia, Dependencia from Dependencias Order by Dependencia"
            Cx.Open()
            Dim Cmd As New SqlCommand(SQL_Str, Cx)
            Cmd.CommandType = CommandType.Text
            Dim DA As New SqlDataAdapter(Cmd)
            Dim DS As New DataSet
            DA.Fill(DS, "Tabla")
            With ComboBox_Dependencia
                .DataSource = DS.Tables("Tabla")
                .DisplayMember = "Dependencia"
                .ValueMember = "Id_Dependencia"
            End With
            Dependencias_Cargadas = True
        Catch ex As SqlException
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If Cx.State = ConnectionState.Open Then
                Cx.Close()
            End If
        End Try
    End Sub
    Sub Carga_Datos_EmpleadosPromo()
        Try

            Dim DependenciaActual As Integer = ComboBox_Dependencia.SelectedValue
            SQL_Str = "Select Persona from PersonaldelasDependencias Where id_Dependencia =2 Order by Persona"
            Cx.Open()
            Dim Cmd As New SqlCommand(SQL_Str, Cx)
            Cmd.CommandType = CommandType.Text
            Dim Reader As SqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection)
            With Reader
                If .HasRows Then
                    While .Read
                        CheckedListBox1.Items.Add(.Item("Persona"))
                    End While
                End If
            End With
        Catch ex As SqlException
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If Cx.State = ConnectionState.Open Then
                Cx.Close()
            End If
        End Try
    End Sub
    Sub Carga_Datos_Personal()
        Try
            If IsDBNull(ComboBox_Dependencia.SelectedValue) = False Then
                Dim DependenciaActual As Integer = ComboBox_Dependencia.SelectedValue
                SQL_Str = "Select Id_Persona, Persona from PersonaldelasDependencias Where id_Dependencia = @Dependencia Order by Persona"
                Cx.Open()
                Dim Cmd As New SqlCommand(SQL_Str, Cx)
                Cmd.CommandType = CommandType.Text
                Cmd.Parameters.AddWithValue("@Dependencia", DependenciaActual)
                Dim DA As New SqlDataAdapter(Cmd)
                Dim DS As New DataSet
                DA.Fill(DS, "Tabla")
                With ComboBox_Remitente
                    .DataSource = DS.Tables(0)
                    .DisplayMember = "Persona"
                    .ValueMember = "Id_Persona"
                End With
            End If

        Catch ex As SqlException
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If Cx.State = ConnectionState.Open Then
                Cx.Close()
            End If
        End Try
    End Sub

    Private Sub Button_CargaDocumento_Click(sender As Object, e As EventArgs) Handles Button_CargaDocumento.Click
        Dim myStream As String = Nothing
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Archivos PDF (*.pdf)|*.pdf"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog1.FileName
                If (myStream IsNot Nothing) Then
                    TextBox_Documento.Text = myStream.ToString
                End If
            Catch ex As Exception
                MessageBox.Show("No se puede leer el archivo indicado. Error:" & ex.Message)
            End Try
        End If

    End Sub

    Private Sub Button_Cancelar_Click(sender As Object, e As EventArgs) Handles Button_Cancelar.Click
        Close()

    End Sub

    Private Sub leerEmail(ByVal Persona As String)
        SQL_Str = "Select email from PersonaldelasDependencias where id_Dependencia = 2 and Persona in (@Destinatario)"
        Try
            Cx.Open()
            Dim Cmd As New SqlCommand(SQL_Str, Cx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Destinatario", Persona)
            Dim Reader As SqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection)
            With Reader
                If .HasRows Then
                    While .Read
                        _Oficio.email = .Item("email")
                    End While
                End If
            End With
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MessageBoxIcon.Error, MessageBoxButtons.OK)
        Finally
            If Cx.State = ConnectionState.Open Then
                Cx.Close()
            End If
        End Try
    End Sub

    Private Sub Button_Aceptar_Click(sender As Object, e As EventArgs) Handles Button_Aceptar.Click
        Dim x As Integer
        Dim s As String = ""
        If CheckedListBox1.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.
            If CheckedListBox1.CheckedItems.Count = 1 Then
                For x = 0 To CheckedListBox1.CheckedItems.Count - 1
                    s = s & CheckedListBox1.CheckedItems(x).ToString
                Next x
            Else
                s = CheckedListBox1.CheckedItems(0).ToString
                For x = 1 To CheckedListBox1.CheckedItems.Count - 1
                    s = s & "," & CheckedListBox1.CheckedItems(x).ToString
                Next x

            End If
        End If

        _Oficio.NumOficio = TextBoxNumOficio.Text
        _Oficio.FechaOficio = DateTimePicker.Value
        _Oficio.FechaRecepcion = Now
        _Oficio.Destinatario = s
        _Oficio.Remitente = ComboBox_Remitente.Text
        _Oficio.Asunto = TextBox_Oficio.Text
        _Oficio.Observaciones = TextBox_Observaciones.Text
        _Oficio.Path = TextBox_Documento.Text
        Dim PDF_Bytes As Byte()
        If File.Exists(_Oficio.Path) Then
            PDF_Bytes = File.ReadAllBytes(_Oficio.Path)
            SQL_Str = "Insert into Documento (NumeroOficio, FechaOficio, FechaRecepcion, Asunto, Observaciones, Remitente, Destinatario, PDF)" &
                "Values (@NumeroOficio, @FechaOficio, @FechaRecepcion, @Asunto, @Observaciones, @Remitente, @Destinatario, @PDF)"

            Try
                Dim Cmd As New SqlCommand(SQL_Str, Cx)
                Cx.Open()
                Cmd.CommandType = CommandType.Text
                Cmd.Parameters.AddWithValue("@NumeroOficio", _Oficio.NumOficio)
                Cmd.Parameters.AddWithValue("@FechaOficio", _Oficio.FechaOficio)
                Cmd.Parameters.AddWithValue("@FechaRecepcion", _Oficio.FechaRecepcion)
                Cmd.Parameters.AddWithValue("@Asunto", _Oficio.Asunto)
                Cmd.Parameters.AddWithValue("@Observaciones", _Oficio.Observaciones)
                Cmd.Parameters.AddWithValue("@Remitente", _Oficio.Remitente)
                Cmd.Parameters.AddWithValue("@Destinatario", _Oficio.Destinatario)
                Cmd.Parameters.AddWithValue("@PDF", PDF_Bytes)
                Cmd.ExecuteNonQuery()


            Catch ex As SqlException
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Cx.State = ConnectionState.Open Then
                    Cx.Close()
                End If

            End Try

            Try

            Catch ex As SqlException
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Cx.State = ConnectionState.Open Then
                    Cx.Close()
                End If
            End Try

            Envia_Mail()
            Close()
        End If
    End Sub

    Private Sub Envia_Mail()

        Try
            Dim _Remite As String = "oficialiadepartes@promotoraslp.gob.mx"
            Dim _Puerto As Integer = 587
            Dim _Servidor As String = "geo.websitewelcome.com"
            Dim _Usuario As String = "oficialiadepartes@promotoraslp.gob.mx"
            If File.Exists(_Oficio.Path) Then
                Dim ArchivosAdjuntos As New List(Of String)()
                ArchivosAdjuntos.Add(_Oficio.Path)
                enviarCorreoE(_Remite, _Oficio.Destinatario, _Oficio.Asunto, _Oficio.Observaciones, ArchivosAdjuntos, _Servidor, _Puerto, True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, AcceptButton)
        End Try
    End Sub

    Public Sub enviarCorreoE(ByVal Remitente As String,
                             ByVal Destinatario As String,
                             ByVal Asunto As String,
                             ByVal Cuerpo As String,
                             ByVal RutaArchivos As List(Of String),
                             ByVal ServidorSmtp As String,
                             ByRef PuertoSmtp As Integer,
                             Optional ByVal MostrarMensajeOk As Boolean = False)
        Try
            Dim smtpMail As New SmtpClient
            Dim oMsg As System.Net.Mail.MailMessage = New System.Net.Mail.MailMessage()
            oMsg.From = New System.Net.Mail.MailAddress(Remitente)
            For Each Persona As String In Destinatario.Split(",")
                leerEmail(Persona)
                oMsg.To.Add(New System.Net.Mail.MailAddress(_Oficio.email))
            Next
            oMsg.Subject = Asunto
            oMsg.Body = Cuerpo
            oMsg.IsBodyHtml = True
            Dim i As Integer = 0
            Dim ruta As List(Of String) = New List(Of String)
            If RutaArchivos.Count > 0 Then
                While (i < RutaArchivos.Count)
                    Dim sFile As String = RutaArchivos(i)
                    Dim oAttch As Net.Mail.Attachment = New Net.Mail.Attachment(sFile, "")
                    oMsg.Attachments.Add(oAttch)
                    i = i + 1
                End While
            End If

            smtpMail.Host = ServidorSmtp
            smtpMail.Credentials = New System.Net.NetworkCredential(Remitente, "esm9708")
            smtpMail.Port = PuertoSmtp
            smtpMail.EnableSsl = True
            smtpMail.Send(oMsg)
            If MostrarMensajeOk Then
                MsgBox("Mensaje enviado correctamente",
                       MsgBoxStyle.Information)
            End If

        Catch ex As SmtpFailedRecipientException
            If MostrarMensajeOk Then
                MsgBox("Error: " & ex.Message & "   - Mensaje no enviado")
            End If
        Catch ex As SmtpException
            If MostrarMensajeOk Then
                MsgBox("Error: " & ex.Message & "   - Mensaje no enviado")
            End If
        Catch ex As Exception
            If MostrarMensajeOk Then
                MsgBox("Error: " & ex.Message & "   - Mensaje no enviado")
            End If
        End Try
    End Sub

    Private Sub TextBoxNumOficio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNumOficio.KeyPress

        If e.KeyChar = "/" Then
            e.KeyChar = ""
        ElseIf e.KeyChar = "\" Then
            e.KeyChar = ""
        ElseIf e.KeyChar = "." Then
            e.KeyChar = ""
        End If

    End Sub

    Private Sub ComboBox_Dependencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Dependencia.SelectedIndexChanged
        If Dependencias_Cargadas = True Then
            Carga_Datos_Personal()
        End If

    End Sub
End Class