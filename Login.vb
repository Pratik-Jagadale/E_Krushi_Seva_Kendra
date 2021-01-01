Imports System.Data.SqlClient

Public Class fem_login

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_user_name.Focus()
    End Sub

    Private Sub tb_user_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_user_name.TextChanged
        tb_Password.Enabled = True
    End Sub

    Private Sub tb_Password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Password.TextChanged
        btn_login.Enabled = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim name As String

        con.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=loginbutton;Integrated Security=True"
        con.Open()

        cmd.Connection = con
        cmd.CommandText = "select * from login where username = '" + tb_user_name.Text + "' and password = '" + tb_Password.Text + "' "
        name = cmd.ExecuteScalar
        If (name <> "") Then
            If (tb_user_name.Text = "Vishal") Then
                MessageBox.Show("Welcome Admin", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("Welcome User", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
        Main_Menu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
End Class
