Imports MySql.Data.MySqlClient
Public Class Form3
    Private comando As MySqlCommand
    Private conexao As MySqlConnection
    Private dr As MySqlDataAdapter
    Private da As MySqlDataReader
    Dim SqlStr As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            conexao = New MySqlConnection("Server=localhost;Database=empresa;Uid=root;Pwd= ;")

            SqlStr = "INSERT INTO DEPARTAMENTO (DEPNOME) VALUES (@DEPARTAMENT)"
            comando = New MySqlCommand(SqlStr, conexao)

            comando.Parameters.AddWithValue("@DEPARTAMENT", TextBox2.Text)

            conexao.Open()
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Deu erro em")
        Finally
            conexao.Close()
            conexao = Nothing
            comando = Nothing
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            conexao = New MySqlConnection("Server=localhost;Database=empresa;Uid=root;Pwd= ;")

            SqlStr = "UPDATE INTO DEPARTAMENTO DEPNOME VALUES WHERE DEPCODIGO = @DEPCODIGO"
            comando = New MySqlCommand(SqlStr, conexao)

            comando.Parameters.AddWithValue("@DEPARTAMENT", TextBox2.Text)

            conexao.Open()
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Deu erro em")
        Finally
            conexao.Close()
            conexao = Nothing
            comando = Nothing
        End Try

    End Sub
End Class