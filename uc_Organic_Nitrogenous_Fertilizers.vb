Public Class uc_Organic_Nitrogenous_Fertilizers
    Dim x As Integer = 0
    Dim y As Integer = 0

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Main_Menu.panel_Main_Menu.Controls.Clear()

        Dim obj = New uc_About_Fertilizers
        Main_Menu.panel_Main_Menu.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub
End Class
