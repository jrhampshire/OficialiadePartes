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
        '  Carga_Datos_Dependencias()
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
                .DataSource = DS.Tables("Tabla")
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
            If IsDBNull(ComboBox1.SelectedValue) = False Then
                Dim DependenciaActual As Integer = ComboBox1.SelectedValue
                SQL_Str = "Select Id_Persona as ID, Persona as Nombre, email from PersonaldelasDependencias Where id_Dependencia = @Dependencia"
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
            End If

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
        'TODO: esta línea de código carga datos en la tabla 'CorrespondenciaDataSet2.Dependencias' Puede moverla o quitarla según sea necesario.
        Me.DependenciasTableAdapter2.Fill(Me.CorrespondenciaDataSet2.Dependencias)

        Carga_Datos_Personal()

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Dim DependenciaActual As String = ComboBox1.SelectedText
        If DependenciaActual IsNot Nothing Then
            Carga_Datos_Personal()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_Agregar.Click
        Dim Nombre As String = Nothing
        Dim email As String = Nothing
        Dim Id_Dependencia As Integer = 0
        Id_Dependencia = ComboBox1.SelectedValue
        If Id_Dependencia = 0 Then
            Exit Sub
            MessageBox.Show("Error al intentar obtener el Id de la Dependencia")
        End If
        Nombre = TextBox_Nombre.Text
        If Nombre = "" Then
            MessageBox.Show("Este Dato es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox_Nombre.Focus()
            Exit Sub

        End If
        email = TextBox_email.Text

        Dim Transaccion As SqlTransaction = Nothing
        Try
            Cx.Open()
            Transaccion = Cx.BeginTransaction("Inserta Personal")
            SQL_Str = "Insert into Personas(Persona,email) Values(@Nombre,@email); Select @ID = @@Identity"
            Dim Cmd As New SqlCommand(SQL_Str, Cx)
            Cmd.CommandType = CommandType.Text
            Cmd.Transaction = Transaccion
            Cmd.Parameters.AddWithValue("@Nombre", Nombre)
            Cmd.Parameters.AddWithValue("@email", email)
            Cmd.Parameters.Add("@ID", SqlDbType.Int)
            Cmd.Parameters("@ID").Direction = ParameterDirection.Output
            Cmd.ExecuteNonQuery()
            Dim Id_Persona As Integer = Cmd.Parameters("@ID").Value.ToString
            SQL_Str = "Insert into Personas_x_Dependencia(Id_Persona, Id_Dependencia) Values(@Id_Persona, @Id_Dependencia)"
            Cmd.CommandType = CommandType.Text
            Cmd.Transaction = Transaccion
            Cmd.CommandText = SQL_Str
            Cmd.Parameters.AddWithValue("@Id_Persona", Id_Persona)
            Cmd.Parameters.AddWithValue("@Id_Dependencia", Id_Dependencia)
            Cmd.ExecuteNonQuery()
            Transaccion.Commit()
            Carga_Datos_Personal()
            TextBox_Nombre.Text = ""
            TextBox_email.Text = ""
            TextBox_Nombre.Focus()


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

    Private Sub Button_Salir_Click(sender As Object, e As EventArgs) Handles Button_Salir.Click
        Close()

    End Sub

    Private Sub Button_Borrar_Click(sender As Object, e As EventArgs) Handles Button_Borrar.Click
        SQL_Str = "Delete Personas where id_Persona = @ID"
        Dim ID As Integer = 0
        If Me.DataGridView1.RowCount = 0 Then
            Exit Sub
        End If
        Dim columna As Integer, fila As Integer
        columna = 0
        fila = Me.DataGridView1.CurrentCellAddress.Y
        Try
            ID = Me.DataGridView1(columna, fila).Value
            If ID = 0 Then
                MessageBox.Show("Debe seleccionar una Persona a Borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DataGridView1.Focus()
                Exit Sub
            Else
                Try
                    Cx.Open()
                    Dim Cmd As New SqlCommand(SQL_Str, Cx)
                    Cmd.CommandType = CommandType.Text
                    Cmd.Parameters.AddWithValue("@ID", ID)
                    Cmd.ExecuteNonQuery()
                    Carga_Datos_Personal()
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
            MessageBox.Show("Debe seleccionar una Persona a Borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DataGridView1.Focus()
            Exit Sub
        End Try

    End Sub


End Class