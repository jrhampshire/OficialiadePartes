Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class Nueva_Correspondencia
    Dim SQL_Str As String = Nothing
    Dim Cx As New SqlConnection(My.Settings.Cadena)
    Private Sub Nueva_Correspondencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CorrespondenciaDataSet.Personas' Puede moverla o quitarla según sea necesario.
        Me.PersonasTableAdapter.Fill(Me.CorrespondenciaDataSet.Personas)
        'TODO: esta línea de código carga datos en la tabla 'CorrespondenciaDataSet.Dependencias' Puede moverla o quitarla según sea necesario.
        Me.DependenciasTableAdapter.Fill(Me.CorrespondenciaDataSet.Dependencias)

    End Sub

    Private Sub ComboBox_Dependencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Dependencia.SelectedIndexChanged
        Carga_Datos_Personal()

    End Sub
    Sub Carga_Datos_Personal()
        Try
            If IsDBNull(ComboBox_Dependencia.SelectedValue) = False Then
                Dim DependenciaActual As Integer = ComboBox_Dependencia.SelectedValue
                SQL_Str = "Select Id_Persona, Persona from PersonaldelasDependencias Where id_Dependencia = @Dependencia"
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
        ' Call ShowDialog.
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then

            ' Get the file name.
            Dim path As String = OpenFileDialog1.FileName
            Try
                ' Read in text.
                Dim text As String = File.ReadAllText(path)

                ' For debugging.
                Me.Text = text.Length.ToString

            Catch ex As Exception

                ' Report an error.
                Me.Text = "Error"

            End Try
        End If

    End Sub

    Private Sub Button_Cancelar_Click(sender As Object, e As EventArgs) Handles Button_Cancelar.Click
        Close()

    End Sub

    Private Sub Button_Aceptar_Click(sender As Object, e As EventArgs) Handles Button_Aceptar.Click
        Dim _Oficio As New Oficio
        _Oficio.NumOficio = TextBoxNumOficio.Text
        _Oficio.FechaOficio = DateTimePicker.Value
        _Oficio.FechaRecepcion = Now
        _Oficio.Destinatario = ComboBox_Destinatario.SelectedText
        _Oficio.Remitente = ComboBox_Remitente.SelectedText
        _Oficio.Asunto = TextBox_Oficio.Text
        _Oficio.Observaciones = TextBox_Observaciones.Text
        _Oficio.Path = TextBox_Documento.Text


    End Sub
End Class