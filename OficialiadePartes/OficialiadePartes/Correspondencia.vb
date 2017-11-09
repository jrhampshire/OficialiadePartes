Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.IO.Compression
Imports System.Net.Mail
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
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
        Carga_Datos()
    End Sub

    Private Sub Correspondencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DateTimePicker_FechaInicio.Value = PrimerDiaMes(Now)
        Me.DateTimePicker_FechaFin.Value = UltimoDiaMes(Now)
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
            ' MessageBox.Show(ex.Message + " No se puede abrir el documento " & vFilename, "Error")
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
                    If Not File.Exists(_Oficio.Path) Then
                        BytesAArchivo(bytes, _Oficio.Path)
                    End If


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
    Private Sub Button_Borrar_Click(sender As Object, e As EventArgs) Handles Button_Borrar.Click
        Dim Respuesta As DialogResult = Nothing
        Respuesta = MessageBox.Show("Esta a punto de Cancelar el Oficio ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Select Case Respuesta
            Case System.Windows.Forms.DialogResult.Yes
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
                        Carga_Datos()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Debe seleccionar un Equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.DataGridView1.Focus()
                    Exit Sub
                End Try
            Case System.Windows.Forms.DialogResult.No
                Exit Sub
        End Select
    End Sub
    Sub Carga_Datos()
        Dim Fecha_Inicio As Date, Fecha_Fin As Date
        Try
            Fecha_Inicio = Format(Me.DateTimePicker_FechaInicio.Value, "yyyy-MM-dd")
            Fecha_Fin = Format(Me.DateTimePicker_FechaFin.Value, "yyyy-MM-dd")
            'Fecha_Inicio = Me.DateTimePicker_FechaInicio.Value
            'Fecha_Fin = Me.DateTimePicker_FechaFin.Value
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.HResult.ToString, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        SQL_Str = "Select * from ListadoDocumentos Where FechaRecepcion BETWEEN CONVERT(DATETIME, @Fecha10, 102) AND CONVERT(DATETIME, @Fecha20, 102) Order by FechaRecepcion"
        Try
            Cx.Open()
            Dim Cmd As New SqlCommand(SQL_Str, Cx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Fecha10", Fecha_Inicio)
            Cmd.Parameters.AddWithValue("@Fecha20", Fecha_Fin)
            Cmd.ExecuteNonQuery()
            Dim DA As New SqlDataAdapter(Cmd)
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
        Dim Respuesta As DialogResult = Nothing
        Respuesta = MessageBox.Show("Esta a punto de Reenviar el Oficio ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Select Case Respuesta
            Case System.Windows.Forms.DialogResult.Yes
                Envia_Mail()
            Case System.Windows.Forms.DialogResult.No
                Exit Sub
        End Select
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim Busqueda As String = Trim(ToolStripTextBox1.Text)
        SQL_Str = "Select * from ListadoDocumentos Where Id_Documento in (Select Id_Documento from ViewInfo where Info like '%" & Busqueda & "%')"
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

    Function UltimoDiaMes(Fecha As Date) As Date
        UltimoDiaMes = DateSerial(Year(Fecha), Month(Fecha) + 1, 0)
    End Function
    Function PrimerDiaMes(Fecha As Date) As Date
        PrimerDiaMes = DateSerial(Year(Fecha), Month(Fecha), 1)
    End Function

    Private Sub ToolStripButton_Reload_Click(sender As Object, e As EventArgs) Handles ToolStripButton_Reload.Click
        Carga_Datos()
    End Sub

    Private Sub ToolStripButton_Exportar_Click(sender As Object, e As EventArgs) Handles ToolStripButton_Exportar.Click
        Dim DireccionImagenLogo As String = Nothing
        DireccionImagenLogo = "\\SRVPROMOEDO-5\Compartido\Logo PROMOTORASLP 2015-2021.jpg"
        Dim app As Object
        Dim xlbook As Object
        Dim xlsheet As Object
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        Dim thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
        Dim originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
        Try
            app = CreateObject("Excel.Application")
            xlbook = app.Workbooks.Add()
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
            xlsheet = xlbook.ActiveSheet
            Dim range As Excel.Range
            ' Crea una nueva Instancia o Excel y un nuevo workbook.
            thisThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
            If File.Exists(DireccionImagenLogo) Then
                xlsheet.Shapes.AddPicture(DireccionImagenLogo, CType(False, Microsoft.Office.Core.MsoTriState), CType(True, Microsoft.Office.Core.MsoTriState), 5, 5, 130, 55)
            End If
            xlsheet.Range("A1").EntireRow.RowHeight = 65
            xlsheet.Cells(1, 8).Formula = Now
            'xlsheet.Range("A7").VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            'xlsheet.Range("A7").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            xlsheet.Range("A2").Font.Bold = True
            xlsheet.Range("A2").Font.Size = 18
            xlsheet.Range("A2").Interior.ColorIndex = 16
            xlsheet.Range("A2").Value = "Oficios Recibidos"
            xlsheet.Range("A2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xlsheet.Range("A2").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlsheet.Range("A2:H3").Merge()
            xlsheet.Range("A2:H3").BorderAround(, Excel.XlBorderWeight.xlMedium,
                    Excel.XlColorIndex.xlColorIndexAutomatic, )
            xlsheet.Range("A5").Font.Bold = False
            xlsheet.Range("A5").Font.Size = 12
            xlsheet.Cells(4, 1).Formula = "ID"
            xlsheet.Cells(4, 2).Formula = "Oficio"
            xlsheet.Cells(4, 3).Formula = "Fecha de Oficio"
            xlsheet.Cells(4, 4).Formula = "Fecha de Recepcion"
            xlsheet.Cells(4, 5).Formula = "Asunto"
            xlsheet.Cells(4, 6).Formula = "Observaciones"
            xlsheet.Cells(4, 7).Formula = "Remitente"
            xlsheet.Cells(4, 8).Formula = "Destinatario"
            xlsheet.Range("A4:H4").Font.Bold = True
            xlsheet.Range("A4:H4").Interior.ColorIndex = 16
            xlsheet.Range("A4:H4").Font.Size = 11
            xlsheet.Range("A4:H4").Borders().Color = 0
            xlsheet.Range("A4:H4").Borders().LineStyle = Excel.XlLineStyle.xlContinuous
            xlsheet.Range("A4:H4").Borders().Weight = 2
            xlsheet.Range("A4:H4").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            Dim R As String = "A4:A" + CInt(DataGridView1.RowCount + 5).ToString
            xlsheet.Range(R).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xlsheet.Range("A1").EntireColumn.ColumnWidth = 8
            xlsheet.Range("B1").EntireColumn.ColumnWidth = 20
            xlsheet.Range("C1").EntireColumn.ColumnWidth = 15
            xlsheet.Range("D1").EntireColumn.ColumnWidth = 15
            xlsheet.Range("E1").EntireColumn.ColumnWidth = 25
            xlsheet.Range("F1").EntireColumn.ColumnWidth = 50
            xlsheet.Range("G1").EntireColumn.ColumnWidth = 35
            xlsheet.Range("H1").EntireColumn.ColumnWidth = 35

            'Aqui obtengo el tamaño del datagrid y lo copio al excel
            Dim DGRows As Integer = Me.DataGridView1.RowCount
            Dim DGCols As Integer = Me.DataGridView1.ColumnCount
            range = xlsheet.Range("A5", Reflection.Missing.Value)
            range = range.Resize(DGRows, DGCols)
            range.Borders().Color = 0
            range.Borders().LineStyle = Excel.XlLineStyle.xlContinuous
            range.Borders().Weight = 2
            range.Font.Size = 9
            'Crea un array
            Dim saRet(DGRows, DGCols) As String
            'llena el array.
            Dim iRow As Integer
            Dim iCol As Integer
            For iRow = 0 To DataGridView1.RowCount - 1
                For iCol = 0 To DataGridView1.ColumnCount - 1
                    saRet(iRow, iCol) = DataGridView1.Rows(iRow).Cells(iCol).Value.ToString
                Next iCol
            Next iRow
            'establece el valor del rango del array.
            range.Value = saRet
            'Regresa el control del Excel al usuario y Limpia
            range = Nothing
            app.Visible = True
            app.UserControl = True
            releaseobject(app)
            releaseobject(xlbook)
            releaseobject(xlsheet)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            thisThread.CurrentCulture = originalCulture
        End Try
    End Sub
    Sub releaseobject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        End Try
    End Sub
End Class