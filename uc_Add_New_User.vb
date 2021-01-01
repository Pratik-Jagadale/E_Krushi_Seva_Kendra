Imports System.Data.SqlClient

Public Class uc_Add_New_User
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

    Private Sub uc_Add_New_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Usr_Name.Focus()
    End Sub

    Private Sub txt_Confirm_Pass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Confirm_Pass.TextChanged
        btn_Save.Enabled = True
        btn_Close.Enabled = True
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        connection()

        If txt_Usr_Name.Text <> "" And txt_Enter_Pass.Text <> "" And txt_Confirm_Pass.Text <> "" And txt_Enter_Pass.Text = txt_Confirm_Pass.Text Then
            connection()
            cmd.Connection = con
            cmd.CommandText = "insert into login values ('" + txt_Usr_Name.Text + "','" + txt_Confirm_Pass.Text + "')"

            cmd.ExecuteScalar()
            MessageBox.Show("User Added Succesffuly")
            txt_Usr_Name.Text = ""
            txt_Enter_Pass.Text = ""
            txt_Confirm_Pass.Text = ""

        Else
            MessageBox.Show("Please Enter Correct Information")
        End If
        con.Close()
        cmd.Dispose()
        Common_Class.clear_tb(Main_Menu.panel_Main_Menu)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        Common_Class.clear_tb(Main_Menu.panel_Main_Menu)
        txt_Usr_Name.Focus()
        btn_Save.Enabled = False
        btn_Close.Enabled = False

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
