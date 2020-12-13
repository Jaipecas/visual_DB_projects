Imports MySql.Data.MySqlClient


Public Class MySQLConn
    Dim connection As New MySql.Data.MySqlClient.MySqlConnection()

    'Se agrega la base de datos a la conexión
    Private Sub MySQLConn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.ConnectionString = "server=127.0.0.1;database=bd;user id=root;password=Jaipecas123;Convert Zero Datetime=True"
    End Sub

    'Conecta con la base de datos
    Private Sub connectionBD()
        Try
            connection.Open()
            MessageBox.Show("Conectado")
            connection.Close()
            MessageBox.Show("Desconectado")

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Inserta un nuevo alumno en la base de datos cogiendo los datos de los textBox
    Private Sub insertBD()
        Dim command As New MySqlCommand
        Dim resultados As Integer

        command.CommandText = "INSERT INTO alumnos VALUES ('" & textBox_id.Text & "','" & textBox_nombre.Text & "','" & textBox_apellidos.Text & "','" &
            textBox_anoNac.Text & "-" & textbox_mesNac.Text & "-" & textBox_diaNac.Text & "')"
        command.Connection = connection

        connection.Open()

        Try
            resultados = command.ExecuteNonQuery()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

        MessageBox.Show("Se han añadido " & resultados & " filas")

        'Se limpian los textBox
        textBox_id.Clear()
        textBox_nombre.Clear()
        textBox_apellidos.Clear()
        textBox_diaNac.Clear()
        textbox_mesNac.Clear()
        textBox_anoNac.Clear()

        connection.Close()
    End Sub

    'Se consulta la cantidad de alumnos que hay en la base de datos
    Private Sub consulta_escalar()
        Dim command As New MySqlCommand
        Dim number_alumn As Integer

        command.CommandText = "SELECT COUNT(*) FROM alumnos"
        command.Connection = connection

        connection.Open()
        Try
            number_alumn = command.ExecuteScalar
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

        MessageBox.Show("El número de alumnos es: " & number_alumn)
        connection.Close()
    End Sub

    'Se seleccionan los alumnos de la base de datos y se meten sus nombres en la listbox
    Private Sub consulta_BD()
        Dim command As New MySqlCommand
        Dim reader As MySqlDataReader

        command.CommandText = "SELECT * FROM alumnos"
        command.Connection = connection

        connection.Open()

        Try
            reader = command.ExecuteReader
            listBox_alumnos.Items.Clear()
            While reader.Read
                listBox_alumnos.Items.Add(reader("nombre"))
            End While
            reader.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

        connection.Close()
    End Sub

    'Se trabaja con los datos de la base de datos deconectado a través del dataset
    Private Sub consulta_dataSet()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM alumnos ORDER BY nombre", connection)
        Dim datesSet As New DataSet
        Dim table As DataTable
        Dim row As DataRow

        connection.Open()
        adapter.Fill(datesSet, "alumnos")
        connection.Close()

        table = datesSet.Tables("alumnos")

        listBox_alumnos.Items.Clear()
        For Each row In table.Rows
            listBox_alumnos.Items.Add(row.Item("nombre") + " " + row.Item("apellidos"))
        Next
    End Sub

    Private Sub button_connection_Click(sender As Object, e As EventArgs) Handles button_connection.Click
        connectionBD()
    End Sub

    Private Sub button_insertion_Click(sender As Object, e As EventArgs) Handles button_insertion.Click
        insertBD()
    End Sub

    Private Sub button_consulta_escalar_Click(sender As Object, e As EventArgs) Handles button_consulta_escalar.Click
        consulta_escalar()
    End Sub

    Private Sub button_consulta_Click(sender As Object, e As EventArgs) Handles button_consulta.Click
        consulta_BD()
    End Sub

    Private Sub button_consulta_desconectado_Click(sender As Object, e As EventArgs) Handles button_consulta_desconectado.Click
        consulta_dataSet()
    End Sub
End Class
