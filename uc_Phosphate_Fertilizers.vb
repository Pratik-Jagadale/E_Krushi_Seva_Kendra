Public Class uc_Phosphate_Fertilizers

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Dim y As Integer = 0
        Dim x As Integer = 0
        Main_Menu.panel_Main_Menu.Controls.Clear()

        Dim obj = New uc_About_Fertilizers
        obj.Location = New System.Drawing.Point(x, y)
        Main_Menu.panel_Main_Menu.Controls.Add(obj)
    End Sub
End Class
