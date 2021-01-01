Imports System.Data.SqlClient

Public Class uc_Change_Password
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

    Private Sub btn_Update_Pass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update_Pass.Click
        If txt_New_Pass.Text <> "" And txt_Current_Password.Text <> "" And txt_New_Pass.Text <> "" Then
            connection()
            cmd = New SqlCommand("Update login set password= '" + txt_New_Pass.Text + "' where username = '" + txt_Uname.Text + "' ", con)
            Dim i As Integer = cmd.ExecuteNonQuery
            If (i > 0) Then
                MessageBox.Show(" Password Updated Successfully....")
                txt_Uname.Text = ""
                txt_Current_Password.Text = ""
                txt_New_Pass.Text = ""

            Else
                MessageBox.Show("Server Error???")
            End If
        Else
            MessageBox.Show("Please Fill All Fields")
        End If

    End Sub

    Private Sub uc_Change_Password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
