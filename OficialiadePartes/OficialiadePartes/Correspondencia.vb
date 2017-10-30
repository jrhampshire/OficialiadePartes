Public Class Correspondencia
    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Close()

    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        Dim Frm As New Nueva_Correspondencia
        Frm.ShowDialog()

    End Sub

    Private Sub Correspondencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CorrespondenciaDataSet.Documento' Puede moverla o quitarla según sea necesario.
        Me.DocumentoTableAdapter.Fill(Me.CorrespondenciaDataSet.Documento)
        'TODO: esta línea de código carga datos en la tabla 'CorrespondenciaDataSet.Documento' Puede moverla o quitarla según sea necesario.
        Me.DocumentoTableAdapter.Fill(Me.CorrespondenciaDataSet.Documento)

    End Sub
End Class