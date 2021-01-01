Imports System.Data.SqlClient

Public Class uc_Add_New_Product
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=loginbutton;Integrated Security=True")

    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Sub clear_controls()
        txt_Product_Id.Text = ""
        txt_Product_Name.Text = ""
        cmb_Category.SelectedIndex = -1
        txt_Purchase_Rate.Text = ""
        txt_Sales_Rate.Text = " "
        dtp_Stock_Date.Text = ""
        txt_Stock_Added.Text = " "
        txt_GST_Applied.Text = " "
        txt_Description.Text = " "
    End Sub

    Function auto_incre()
        connection()
        Dim cnt As Integer
        cmd = New SqlCommand("select count(Product_ID)from Tbl_Product", con)
        cnt = cmd.ExecuteScalar
        If cnt = 0 Then
            cnt = 101
        Else
            cnt += 101
        End If
        con.Close()
        Return cnt
    End Function

    Private Sub uc_Add_New_Product_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Product_Name.Focus()
        ''  txt_Product_Id.Text = auto_incre()
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub btn_Save_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim cmd1 As New SqlCommand
        connection()
        If txt_Product_Name.Text <> "" And cmb_Category.Text <> "" And txt_Purchase_Rate.Text <> "" And txt_Stock_Added.Text <> "" And dtp_Stock_Date.Text <> "" And txt_Sales_Rate.Text <> "" And txt_GST_Applied.Text <> "" Then

            cmd = New SqlCommand("insert into Tbl_Product(Product_Id,Product_Name,Category,Purchase_Rate,Sales_Rate,Stock_Added,First_Stock_Date,GST_Applied,Description)values(" & txt_Product_Id.Text & ",'" & txt_Product_Name.Text & "','" & cmb_Category.Text & "'," & txt_Purchase_Rate.Text & "," & txt_Sales_Rate.Text & "," & txt_Stock_Added.Text & ",'" & dtp_Stock_Date.Text & "'," & txt_GST_Applied.Text & ",'" & txt_Description.Text & "')", con)


            cmd1 = New SqlCommand("insert into Tbl_Stock(Product_Id,Product_Name,Category,Stock_Add_Date,Stock_Added)values(" & txt_Product_Id.Text & ",'" & txt_Product_Name.Text & "','" & cmb_Category.Text & "','" & dtp_Stock_Date.Text & "'," & txt_Stock_Added.Text & ")", con)


            Dim i As Integer = cmd.ExecuteNonQuery()
            cmd1.ExecuteNonQuery()

            If (i > 0) Then
                MessageBox.Show(" Record Added Successfully...... ")

                txt_Product_Id.Text = auto_incre()
            Else
                MessageBox.Show("Server Error...")
            End If
        Else
            MessageBox.Show("Fill All Field...")
        End If
        con.Close()
    End Sub

    Private Sub txt_Product_Name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Product_Name.KeyPress, txt_Description.KeyPress, cmb_Category.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z" AndAlso e.KeyChar < "a" OrElse e.KeyChar > "z" AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " ") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Product_Id_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Stock_Added.KeyPress, txt_Sales_Rate.KeyPress, txt_Purchase_Rate.KeyPress, txt_Product_Id.KeyPress, txt_GST_Applied.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9" AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "") Then
            e.Handled = True
        End If
    End Sub
End Class
