Public Class Principal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End

    End Sub

    Private Sub CorrespondenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorrespondenciaToolStripMenuItem.Click
        Dim Frm As New Correspondencia
        Frm.ShowDialog()

    End Sub

    Private Sub SecretariasYDependenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SecretariasYDependenciasToolStripMenuItem.Click
        Dim frm As New Secretarias_y_Dependencias
        frm.ShowDialog()

    End Sub
End Class