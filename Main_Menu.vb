Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class Main_Menu

    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim x As Integer = 0
    Dim y As Integer = 0

    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Private Sub btn_Customer_Master_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Customer_Master.Click
        Common_Class.menu_hide_open(Pnl_Customer_Master)
        If Pnl_Customer_Master.Visible = True Then
            Pnl_Product_Matser.Visible = False
            Pnl_Stock_Master.Visible = False
            Pnl_User_Management.Visible = False
        End If
    End Sub

    Private Sub btn_Product_Master_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Product_Master.Click
        Common_Class.menu_hide_open(Pnl_Product_Matser)
        If Pnl_Product_Matser.Visible = True Then
            Pnl_Customer_Master.Visible = False
            Pnl_Stock_Master.Visible = False
            Pnl_User_Management.Visible = False
        End If
    End Sub

    Private Sub btn_Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Stock.Click
        Common_Class.menu_hide_open(Pnl_Stock_Master)
        If Pnl_Stock_Master.Visible = True Then
            Pnl_Customer_Master.Visible = False
            Pnl_Product_Matser.Visible = False
            Pnl_User_Management.Visible = False
        End If
    End Sub

    Private Sub btn_User_Management_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_User_Management.Click
        Common_Class.menu_hide_open(Pnl_User_Management)
        If Pnl_User_Management.Visible = True Then
            Pnl_Customer_Master.Visible = False
            Pnl_Product_Matser.Visible = False
            Pnl_Stock_Master.Visible = False
        End If
    End Sub

    Private Sub btn_Add_New_Customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_New_Customer.Click
        panel_Main_Menu.Controls.Clear()
        
        Dim obj = New uc_Add_New_Customer
        panel_Main_Menu.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)

    End Sub

    Private Sub btn_Update_Customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        panel_Main_Menu.Controls.Clear()

        Dim obj = New uc_Update_Customer
        panel_Main_Menu.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub btn_View_Customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_View_Customer.Click
        panel_Main_Menu.Controls.Clear()

        Dim obj = New uc_View_Customer
        panel_Main_Menu.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub btn_Add_New_Product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_New_Product.Click
        panel_Main_Menu.Controls.Clear()

        Dim obj = New uc_Add_New_Product
        panel_Main_Menu.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub btn_Update_Product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update_Product.Click
        panel_Main_Menu.Controls.Clear()

        Dim obj = New uc_Update_Product
        panel_Main_Menu.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub btn_View_Product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_View_Product.Click
        panel_Main_Menu.Controls.Clear()

        Dim obj = New uc_View_Product_Details
        panel_Main_Menu.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub btn_Add_New_Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_New_Stock.Click
        panel_Main_Menu.Controls.Clear()

        Dim obj = New uc_Add_New_Stock
        panel_Main_Menu.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub btn_View_Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_View_Stock.Click
        panel_Main_Menu.Controls.Clear()

        Dim obj = New uc_View_stock
        panel_Main_Menu.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub btn_Add_New_User_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_New_User.Click
        panel_Main_Menu.Controls.Clear()

        Dim obj = New uc_Add_New_User
        panel_Main_Menu.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub btn_Change_Password_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Change_Password.Click
        panel_Main_Menu.Controls.Clear()

        Dim obj = New uc_Change_Password
        panel_Main_Menu.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub btn_Delete_Password_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete_Password.Click
        panel_Main_Menu.Controls.Clear()

        Dim obj = New uc_Delete_User
        panel_Main_Menu.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_Jonral_info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Jonral_info.Click
        panel_Main_Menu.Controls.Clear()

        Dim obj = New uc_About_Fertilizers
        panel_Main_Menu.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
End Class
