Imports System.Data.SqlClient

Public Class uc_Update_Product
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=loginbutton;Integrated Security=True")
    Dim dr As SqlDataReader

    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Main_Menu.panel_Main_Menu.Controls.Clear()
    End Sub

    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        connection()
        cmd = New SqlCommand("select * from Tbl_Product where Product_ID = " & txt_Product_Id.Text & "", con)
        dr = cmd.ExecuteReader()

        If dr.Read Then
            txt_Product_Name.Text = dr("Product_Name").ToString
            cmb_Category.Text = dr("Category").ToString
            txt_Purchase_Rate.Text = dr("Purchase_Rate").ToString
            txt_Sales_Rate.Text = dr("Sales_Rate").ToString
            txt_Stock_Added.Text = dr("Stock_Added").ToString
            dtp_Stock_Date.Text = dr("First_Stock_Date").ToString
            txt_GST_Applied.Text = dr("GST_Applied").ToString
            txt_Description.Text = dr("Description").ToString

            txt_Product_Id.Enabled = False
            txt_Product_Id.Enabled = False
            txt_Product_Name.Focus()
        Else
            MessageBox.Show("Record Not Found.....")
            btn_Search.Enabled = True
            txt_Product_Id.Enabled = True
            txt_Product_Id.Text = ""
            txt_Product_Id.Focus()
        End If
        dr.Close()
        con.Close()
    End Sub

    Private Sub btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update.Click
        connection()
        If txt_Product_Name.Text <> "" And cmb_Category.Text <> "" And txt_Purchase_Rate.Text <> "" And txt_Sales_Rate.Text <> "" And txt_Stock_Added.Text <> "" And dtp_Stock_Date.Text <> "" Then

            cmd = New SqlCommand("Update Tbl_Product set Product_Name = '" & txt_Product_Name.Text & "',Category ='" & cmb_Category.Text & "',Purchase_Rate = " & txt_Purchase_Rate.Text & ",Sales_Rate = " & txt_Sales_Rate.Text & ",Stock_Added = " & txt_Stock_Added.Text & ",First_Stock_Date = '" & dtp_Stock_Date.Text & "',GST_Applied=" & txt_GST_Applied.Text & "where Product_ID = " & txt_Product_Id.Text & "", con)
            Dim i As Integer = cmd.ExecuteNonQuery

            Else
                MessageBox.Show("First Fill All The Field..")
            End If
        End
    End Sub

    Private Sub txt_Product_Id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Product_Id.TextChanged
        btn_Search.Enabled = True
    End Sub
End Class
