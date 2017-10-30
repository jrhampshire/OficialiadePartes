Public Class Nueva_Correspondencia
    Private Sub Nueva_Correspondencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CorrespondenciaDataSet.Personas' Puede moverla o quitarla según sea necesario.
        Me.PersonasTableAdapter.Fill(Me.CorrespondenciaDataSet.Personas)
        'TODO: esta línea de código carga datos en la tabla 'CorrespondenciaDataSet.Dependencias' Puede moverla o quitarla según sea necesario.
        Me.DependenciasTableAdapter.Fill(Me.CorrespondenciaDataSet.Dependencias)

    End Sub
End Class