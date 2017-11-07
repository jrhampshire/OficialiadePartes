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

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DirectorioInicio As String = Nothing
        DirectorioInicio = System.AppDomain.CurrentDomain.BaseDirectory()

        If Not My.Computer.FileSystem.DirectoryExists("\\SRVPROMOEDO-5\Compartido\Oficialia_de_Partes") Then
            My.Computer.FileSystem.CreateDirectory("\\SRVPROMOEDO-5\Compartido\Oficialia_de_Partes")
        End If
        If Not My.Computer.FileSystem.DirectoryExists("\\SRVPROMOEDO-5\Compartido\Oficialia_de_Partes\Reportes") Then
            My.Computer.FileSystem.CreateDirectory("\\SRVPROMOEDO-5\Compartido\Oficialia_de_Partes\Reportes")
        End If
        If Not My.Computer.FileSystem.DirectoryExists("\\SRVPROMOEDO-5\Compartido\Oficialia_de_Partes\Archivos") Then
            My.Computer.FileSystem.CreateDirectory("\\SRVPROMOEDO-5\Compartido\Oficialia_de_Partes\Archivos")
        End If
    End Sub
End Class