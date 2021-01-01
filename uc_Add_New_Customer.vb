Imports System.Data.SqlClient

Public Class uc_Add_New_Customer

    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=loginbutton;Integrated Security=True")

    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function

    Function Dependent_combo()
        connection()
        cmd = New SqlCommand("(select * from Tbl_Product where Category='" + cmb_Product_catagory.Text + "')", con)
        Dim Adp As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Adp.Fill(dt)
        cmb_Product_Name.DataSource = dt
        cmb_Product_Name.DisplayMember = "Product_Name"
        cmb_Product_catagory.ValueMember = "Category"

        Return 0
    End Function


    Function auto_incre()
        connection()
        Dim cnt As Integer
        cmd = New SqlCommand("select count(Customer_ID)from Tbl_Customer", con)

        cnt = cmd.ExecuteScalar
        If cnt = 0 Then
            cnt = 1
        Else
            cnt += 1
        End If
        Return cnt
        cmd.Dispose()
        con.Close()

    End Function

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Main_Menu.panel_Main_Menu.Controls.Clear()
    End Sub

    Private Sub uc_Add_New_Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''txt_Customer_Id.Text = auto_incre()
    End Sub

    Private Sub cmb_Product_Name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Product_Name.SelectedIndexChanged
        connection()
        Dim dr As SqlDataReader
        cmd = New SqlCommand("select * from Tbl_Product where Product_Name='" + cmb_Product_Name.Text + "' ", con)
        dr = cmd.ExecuteReader
        If dr.Read Then
            txt_Price.Text = dr("Sales_Rate").ToString
            txt_GST.Text = dr("GST_Applied")
            tb_Product_id.Text = dr("Product_id").ToString

        End If
        dr.Close()
    End Sub

    Private Sub txt_Quantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Quantity.TextChanged
        Dim cnt As Integer = 1
        If txt_Quantity.Text = "" And cnt <> 0 Then
            txt_Total_Price.Text = ""
        Else
            Dim gst As Double = (Val(txt_GST.Text) / 100)
            Dim sum As Double = 0
            sum = txt_Price.Text + gst * (txt_Price.Text)
            sum = sum * txt_Quantity.Text
            txt_Total_Price.Text = sum
            cnt = 0
        End If
    End Sub

    Private Sub txt_Discount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Discount.TextChanged
        Dim dcnt As Double = (Val(txt_Discount.Text) / 100)
        Dim diff As Double = 0
        diff = Val(txt_Bill.Text) - (dcnt * Val(txt_Bill.Text))

        txt_Total_Bill.Text = diff
    End Sub

    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click
        Dim Current_Stock As Integer
        Dim dr As SqlDataReader
        connection()
        cmd = New SqlCommand("select stock_Added from Tbl_Stock where Product_id = " + tb_Product_id.Text + "", con)
        dr = cmd.ExecuteReader
        If dr.Read Then
            Current_Stock = dr("Stock_Added")
        End If
        cmd.Dispose()
        dr.Close()

        If txt_Quantity.Text <> "" And txt_Price.Text <> "" Then
            If Current_Stock < txt_Quantity.Text Then
                MessageBox.Show("There is Not Enough Stock ... Stock Available is = " & Current_Stock.ToString & "")
            Else
                dgv_Customer_Purchase_Details.Rows.Add(txt_Customer_Id.Text, tb_Product_id.Text, cmb_Product_catagory.Text, cmb_Product_Name.Text, txt_Price.Text, txt_GST.Text, txt_Quantity.Text, txt_Total_Price.Text)

            End If
                 Else
            MessageBox.Show("Please Select Product & Enter Quantity To be Added...")
        End If
        txt_Bill.Text = Val(txt_Bill.Text) + Val(txt_Total_Price.Text)

        cmb_Product_catagory.Text = ""
        cmb_Product_Name.SelectedIndex = -1
        txt_Price.Text = ""
        txt_GST.Text = ""
        txt_Quantity.Text = ""
        txt_Total_Price.Text = ""


    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        connection()

        If txt_Customer_Id.Text <> "" And txt_Customer_Name.Text <> "" And dtp_Bill_Date.Text <> "" And txt_Bill.Text > 0 And txt_Discount.Text <> "" And txt_Total_Bill.Text > 0 Then

            cmd = New SqlCommand("insert into Tbl_Customer values(" + txt_Customer_Id.Text + ",'" + txt_Customer_Name.Text + "'," + txt_Mob_No.Text + ",'" + dtp_Bill_Date.Text + "'," + txt_Bill.Text + "," + txt_Discount.Text + "," + txt_Total_Bill.Text + ")", con)

            Dim i As Integer = cmd.ExecuteNonQuery()
            cmd.Dispose()
            i = 0
            While dgv_Customer_Purchase_Details.Rows.Count

                If i = dgv_Customer_Purchase_Details.Rows.Count Then
                    Exit While
                End If

                cmd = New SqlCommand("insert into Tbl_Customer_Purchase_Details values(" + dgv_Customer_Purchase_Details.Rows(i).Cells(0).Value + "," + dgv_Customer_Purchase_Details.Rows(i).Cells(1).Value + ",'" + dgv_Customer_Purchase_Details.Rows(i).Cells(2).Value + "','" + dgv_Customer_Purchase_Details.Rows(i).Cells(3).Value + "'," + dgv_Customer_Purchase_Details.Rows(i).Cells(4).Value + "," + dgv_Customer_Purchase_Details.Rows(i).Cells(5).Value + "," + dgv_Customer_Purchase_Details.Rows(i).Cells(6).Value + "," + dgv_Customer_Purchase_Details.Rows(i).Cells(7).Value + ")", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                i = i + 1

            End While


            If (i > 0) Then
                MessageBox.Show("Record Added Successfully..")
            Else
                MessageBox.Show("SEREVER ERROR")
            End If
        End If
        con.Close()
        dgv_Customer_Purchase_Details.Rows.Clear()


        txt_Customer_Name.Text = ""
        txt_Bill.Text = ""
        txt_Mob_No.Text = ""
        txt_Discount.Text = ""
        txt_Total_Bill.Text = ""

        txt_Customer_Id.Text = auto_incre()
    End Sub

    Private Sub tb_Product_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Product_id.TextChanged
        connection()
        Dim dr As SqlDataReader
        cmd = New SqlCommand("select * from Tbl_Product where Product_ID ='" + tb_Product_id.Text + "' ", con)
        dr = cmd.ExecuteReader
        If dr.Read Then
            cmb_Product_catagory.Text = dr("category").ToString
            cmb_Product_Name.Text = dr("Product_Name").ToString
            txt_Price.Text = dr("Sales_Rate").ToString
            txt_GST.Text = dr("GST_Applied")

        End If
        dr.Close()
    End Sub

    Private Sub txt_Customer_Id_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Customer_Id.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9" AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Mob_No_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Mob_No.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9" AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "") Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Product_id_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Product_id.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9" AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Quantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Quantity.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9" AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Discount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Discount.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9" AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Customer_Name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Customer_Name.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z" AndAlso e.KeyChar < "a" OrElse e.KeyChar > "z" AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " ") Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmb_Product_catagory_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Product_catagory.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z" AndAlso e.KeyChar < "a" OrElse e.KeyChar > "z" AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " ") Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmb_Product_Name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Product_Name.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z" AndAlso e.KeyChar < "a" OrElse e.KeyChar > "z" AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " ") Then
            e.Handled = True
        End If
    End Sub
End Class
