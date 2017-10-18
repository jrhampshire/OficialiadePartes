Public Class Principal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End

    End Sub

    Private Sub CorrespondenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorrespondenciaToolStripMenuItem.Click
        Dim Frm As New Correspondencia
        Frm.ShowDialog()

    End Sub
End Class