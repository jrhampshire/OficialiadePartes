Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient



Public Class Secretarias_y_Dependencias
    Dim SQL_Str As String = Nothing
    Dim Cx As New SqlConnection(My.Settings.Cadena)
    Dim Cx1 As New SqlConnection(My.Settings.Cadena)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New Nueva_Dependencia
        frm.ShowDialog()
        Carga_Datos_Dependencias()
    End Sub
    Sub Carga_Datos_Dependencias()
        Try
            SQL_Str = "Select * from Dependencias Order by Dependencia"
            Cx.Open()
            Dim Cmd As New SqlCommand(SQL_Str, Cx)
            Cmd.CommandType = CommandType.Text
            Dim DA As New SqlDataAdapter(Cmd)
            Dim DS As New DataSet
            DA.Fill(DS, "Tabla")
            With ComboBox1
                .DataSource = DS.Tables(0)
                .DisplayMember = "Dependencia"
                .ValueMember = "Id_Dependencia"
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
            Dim DependenciaActual As String = ComboBox1.SelectedText
            SQL_Str = "Select Id_Persona as ID, Persona as Nombre, email from PersonaldelasDependencias Where Dependencia = @Dependencia"
            Cx1.Open()
            Dim Cmd As New SqlCommand(SQL_Str, Cx1)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Dependencia", DependenciaActual)
            Dim DA As New SqlDataAdapter(Cmd)
            Dim DS As New DataSet
            DA.Fill(DS, "Tabla")
            With DataGridView1
                .DataSource = DS.Tables(0)
            End With
        Catch ex As SqlException
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If Cx1.State = ConnectionState.Open Then
                Cx1.Close()
            End If
        End Try
    End Sub

    Private Sub Secretarias_y_Dependencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Datos_Dependencias()

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Dim DependenciaActual As String = ComboBox1.SelectedText
        If DependenciaActual IsNot Nothing Then
            Carga_Datos_Personal()

        End If
    End Sub
    ''' <summary>
    ''' Aqui me quede falta cambiar la consulta para guardar un nuevo personal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Transaccion As SqlTransaction = Nothing
        Try
            Cx.Open()
            Transaccion = Cx.BeginTransaction("Inserta Empleado")
            SQL_Str = "Insert into Personas(Nombre) Values(@Nombre); Select @ID = @@Identity"
            Dim Cmd As New SqlCommand(SQL_Str, Cx)
            Cmd.CommandType = CommandType.Text
            Cmd.Transaction = Transaccion
            Cmd.Parameters.AddWithValue("@Nombre", Nombre)
            Cmd.Parameters.Add("@ID", SqlDbType.Int)
            Cmd.Parameters("@ID").Direction = ParameterDirection.Output
            Cmd.ExecuteNonQuery()
            Dim Id_Persona As Integer = Cmd.Parameters("@ID").Value.ToString
            SQL_Str = "Insert into Empleados(Id_Persona, Id_Puesto, Id_Area) Values(@Id_Persona, @Id_Puesto, @Id_Area)"
            Cmd.CommandType = CommandType.Text
            Cmd.Transaction = Transaccion
            Cmd.CommandText = SQL_Str
            Cmd.Parameters.AddWithValue("@Id_Persona", Id_Persona)
            Cmd.Parameters.AddWithValue("@Id_Puesto", Id_Puesto)
            Cmd.Parameters.AddWithValue("@Id_Area", Id_Area)
            Cmd.ExecuteNonQuery()
            Transaccion.Commit()
            Me.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Try
                Transaccion.Rollback()
            Catch ex2 As Exception
                MessageBox.Show("Message: {0}" + ex2.Message, "Rollback Exception Type: {0}" & ex2.GetType.ToString, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Try
                Transaccion.Rollback()
            Catch ex2 As Exception
                MessageBox.Show("Message: {0}" + ex2.Message, "Rollback Exception Type: {0}" & ex2.GetType.ToString, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Exit Sub
        Finally
            If Cx.State = ConnectionState.Open Then
                Cx.Close()
            End If
        End Try
    End Sub
End Class