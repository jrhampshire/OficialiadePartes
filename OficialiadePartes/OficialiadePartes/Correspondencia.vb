Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.IO.Compression
Imports System.Net.Mail

Public Class Correspondencia
#Region "Variables"
    Dim SQL_Str As String = Nothing
    Dim Cx As New SqlConnection(My.Settings.Cadena)
    Dim _Oficio As New Oficio

#End Region
    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Close()

    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        Dim Frm As New Nueva_Correspondencia
        Frm.ShowDialog()

    End Sub

    Private Sub Correspondencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Datos()
    End Sub
    'La primera te convierte un archivo a bytes, pasándole el path del archivo
    Private Function ArchivoABytes(ByVal pth As String) As Byte()
        Try
            Dim fs As New FileStream(pth, FileMode.Open)
            fs.Position = 0
            Dim bytes(0 To fs.Length - 1) As Byte
            fs.Read(bytes, 0, fs.Length)
            fs.Close()
            '            File.Delete(pth)
            Return bytes
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function
    'Esta te convierte bytes a un archivo, pasándole el path del archivo incluyendo nombre y extensión.
    Private Sub BytesAArchivo(ByVal bytes() As Byte, ByVal Path As String)
        Dim K As Long
        If bytes Is Nothing Then Exit Sub
        Try
            K = UBound(bytes)
            Dim fs As New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(bytes, 0, K)
            fs.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub AbrirDocumento(ByVal vFilename As String)
        Dim pr As System.Diagnostics.Process
        pr = New System.Diagnostics.Process
        Try
            pr.StartInfo.FileName = vFilename
            pr.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            pr.Start()
            'Espera el proceso para que lo termine y continuar
            pr.WaitForExit()
            'Liberar
            pr.Close()
            My.Computer.FileSystem.DeleteFile(vFilename)
        Catch ex As Exception
            MessageBox.Show(ex.Message + " No se puede abrir el documento " & vFilename, "Error")
        End Try
    End Sub

    Private Sub Button_PDF_Click(sender As Object, e As EventArgs) Handles Button_PDF.Click

        GeneraPDF()
        AbrirDocumento(_Oficio.Path)


    End Sub
    Public Sub GeneraPDF()
        Dim bytes() As Byte = Nothing
        Dim Id_Doc As Integer = 0
        SQL_Str = "SELECT * FROM Documento WHERE Id_Documento = @Id_Doc"
        If Me.DataGridView1.RowCount = 0 Then
            Exit Sub
        End If
        Dim columna As Integer, fila As Integer
        columna = 0
        fila = Me.DataGridView1.CurrentCellAddress.Y
        Try
            Id_Doc = Me.DataGridView1(columna, fila).Value
            If Id_Doc = 0 Then
                MessageBox.Show("Debe seleccionar un Equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DataGridView1.Focus()
                Exit Sub
            Else
                If Cx.State = ConnectionState.Open Then
                    Cx.Close()
                End If
                Cx.Open()
                Dim Cmd As New SqlCommand(SQL_Str, Cx)
                Cmd.CommandType = CommandType.Text
                Cmd.Parameters.AddWithValue("@Id_Doc", Id_Doc)
                Dim Reader As SqlDataReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection)
                If Reader.HasRows Then
                    While Reader.Read
                        bytes = Reader.Item("PDF")
                        _Oficio.NumOficio = Reader.Item("NumeroOficio")
                        _Oficio.Destinatario = Reader.Item("Destinatario")
                        _Oficio.Asunto = Reader.Item("Asunto")
                        _Oficio.Observaciones = Reader.Item("Observaciones")

                    End While
                    _Oficio.Path = "\\SRVPROMOEDO-5\Compartido\Oficialia_de_Partes\Archivos\Oficio_" & _Oficio.NumOficio & ".pdf"
                    BytesAArchivo(bytes, _Oficio.Path)

                End If
            End If
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If Cx.State = ConnectionState.Open Then
                Cx.Close()
            End If
        End Try
    End Sub
    Private Sub Envia_Mail()
        GeneraPDF()

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
            Dim oMsg As New System.Net.Mail.MailMessage(Remitente, Destinatario, Asunto, Cuerpo)
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

    Private Sub Button_Borrar_Click(sender As Object, e As EventArgs) Handles Button_Borrar.Click
        SQL_Str = "UPDATE Documento Set Activo = 0 WHERE Id_Documento = @Id_Doc"
        Dim Id_Doc As Integer = 0
        If Me.DataGridView1.RowCount = 0 Then
            Exit Sub
        End If
        Dim columna As Integer, fila As Integer
        columna = 0
        fila = Me.DataGridView1.CurrentCellAddress.Y
        Try
            Id_Doc = Me.DataGridView1(columna, fila).Value
            If Id_Doc = 0 Then
                MessageBox.Show("Debe seleccionar un Equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DataGridView1.Focus()
                Exit Sub
            Else
                Try
                    Cx.Open()
                    Dim Cmd As New SqlCommand(SQL_Str, Cx)
                    Cmd.CommandType = CommandType.Text
                    Cmd.Parameters.AddWithValue("@Id_Doc", Id_Doc)
                    Cmd.ExecuteNonQuery()
                    Carga_Datos()
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Finally
                    If Cx.State = ConnectionState.Open Then
                        Cx.Close()
                    End If
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show("Debe seleccionar un Equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DataGridView1.Focus()
            Exit Sub
        End Try
    End Sub
    Sub Carga_Datos()
        SQL_Str = "Select * from ListadoDocumentos"
        Try
            Cx.Open()
            Dim DA As New SqlDataAdapter(SQL_Str, Cx)
            Dim DS As New DataSet
            DA.Fill(DS, "Tabla")
            Me.DataGridView1.DataSource = DS.Tables("Tabla")
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If Cx.State = ConnectionState.Open Then
                Cx.Close()
            End If
        End Try
    End Sub

    Private Sub Button_Correo_Click(sender As Object, e As EventArgs) Handles Button_Correo.Click

    End Sub
End Class