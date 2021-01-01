Imports System.Data.SqlClient

Public Class uc_Delete_User
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=loginbutton;Integrated Security=True")

    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Main_Menu.panel_Main_Menu.Controls.Clear()
    End Sub

    Private Sub btn_Delete_User_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete_User.Click
        connection()
        cmd = New SqlCommand("select * from login where username = '" + txt_U_Name.Text + "' ", con)

        Dim i As Integer = cmd.ExecuteNonQuery

        If (i >= 0) Then
            cmd = New SqlCommand("Delete from login where username = '" + txt_U_Name.Text + "' ", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("User Deleted Successful...")
            txt_U_Name.Text = ""
            txt_Pwd.Text = ""
        Else
            MessageBox.Show("Invalid Details")
            txt_U_Name.Text = ""
            txt_Pwd.Text = ""
            txt_U_Name.Focus()
        End If
        cmd.Dispose()
    End Sub

    Private Sub uc_Delete_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
