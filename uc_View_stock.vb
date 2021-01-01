Imports System.Data.SqlClient

Public Class uc_View_stock
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

    Private Sub uc_View_stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''Try
        ''    connection()
        ''    cmb_Search_Distributor.Focus()
        ''    cmb_Search_Distributor.Text = " "

        ''    cmd = New SqlCommand("select * from Tbl_Stock", con)


        ''    Dim da As New SqlDataAdapter(cmd)
        ''    Dim dt As New DataTable()

        ''    da.Fill(dt)

        ''    dgv_Stock_Detail.DataSource = dt
        ''    cmd.Dispose()
        ''    con.Close()
        ''Catch ex As Exception
        ''    MsgBox(ex.Message)
        ''End Try

    End Sub

    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        Try
            connection()
            If cmb_Search_Distributor.Text = "Product ID" Then
                cmd = New SqlCommand("select * from Tbl_Stock where Product_Id like'%" & txt_Product_Id.Text & "%'", con)
            Else
                cmd = New SqlCommand("select * from Tbl_Stock where Product_Name like'%" & txt_Product_Id.Text & "%'", con)
            End If

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            dgv_Stock_Detail.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
