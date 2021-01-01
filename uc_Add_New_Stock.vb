Imports System.Data.SqlClient

Public Class uc_Add_New_Stock
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=loginbutton;Integrated Security=True")
    Dim dr As SqlDataReader

    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Main_Menu.panel_Main_Menu.Controls.Clear()
    End Sub

    Private Sub uc_Add_New_Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Product_Id.Focus()
    End Sub

    Private Sub txt_Current_Stock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Stock_Added.KeyPress, txt_Product_Id.KeyPress, txt_Current_Stock.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9" AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Category_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Category.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z" AndAlso e.KeyChar < "a" OrElse e.KeyChar > "z" AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " ") Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        connection()

        cmd = New SqlCommand("select * from Tbl_Stock Where Product_id = " & txt_Product_Id.Text & "", con)
        dr = cmd.ExecuteReader

        If dr.Read Then
            txt_Product_Name.Text = dr("Product_Name").ToString
            txt_Category.Text = dr("Category").ToString
            txt_Current_Stock.Text = dr("Stock_Added").ToString
        Else
            MessageBox.Show("Invalid Product ID")
        End If
        cmd.Dispose()
        dr.Close()
        con.Close()
    End Sub

    Private Sub btn_Update_Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update_Stock.Click
        connection()
        Dim cmd1 As New SqlCommand
        cmd1.Connection = con
        cmd.Connection = con
        Dim sum As Integer = 0
        sum = Val(txt_Current_Stock.Text) + Val(txt_Stock_Added.Text)
        If txt_Product_Id.Text <> "" And txt_Product_Name.Text <> "" And txt_Category.Text <> "" And dtp_Stock_Add_Date.Text <> "" And txt_Stock_Added.Text <> "" Then
            cmd = New SqlCommand("update Tbl_Stock Set Stock_Added =" & sum & " where Product_ID=" + txt_Product_Id.Text + "", con)
            cmd.ExecuteNonQuery()
            cmd1 = New SqlCommand("Update Tbl_Product set  Stock_Added  = " & sum & "where Product_ID = " & txt_Product_Id.Text & "", con)

            Dim i As Integer = cmd1.ExecuteNonQuery
            If (i > 0) Then

                MessageBox.Show("Data Updated Successfully..")

                txt_Product_Id.Text = ""
                txt_Product_Name.Text = ""
                txt_Category.Text = ""
                txt_Stock_Added.Text = ""
                dtp_Stock_Add_Date.Text = ""
                txt_Current_Stock.Text = ""

            End If
        Else
            MessageBox.Show("Fist Fill All The Fields...")
        End If
        cmd.Dispose()
        con.Close()
    End Sub
End Class
