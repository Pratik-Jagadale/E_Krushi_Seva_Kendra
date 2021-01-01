Public Class uc_About_Fertilizers
    Dim x As Integer = 0
    Dim y As Integer = 0

    Private Sub btn_Nitrogenous_Fertilizers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nitrogenous_Fertilizers.Click
        Main_Menu.panel_Main_Menu.Controls.Clear()

        Dim obj = New uc_Nitrogenous_Fertilizers
        obj.Location = New System.Drawing.Point(x, y)
        Main_Menu.panel_Main_Menu.Controls.Add(obj)

    End Sub

    Private Sub btn_Organic_Nitrogenous_Fertilizers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Organic_Nitrogenous_Fertilizers.Click
        Main_Menu.panel_Main_Menu.Controls.Clear()

        Dim obj = New uc_Organic_Nitrogenous_Fertilizers
        obj.Location = New System.Drawing.Point(x, y)
        Main_Menu.panel_Main_Menu.Controls.Add(obj)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Main_Menu.panel_Main_Menu.Controls.Clear()

        Dim obj = New uc_Phosphate_Fertilizers
        Main_Menu.panel_Main_Menu.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Main_Menu.panel_Main_Menu.Controls.Clear()

        Dim obj = New uc_Potassic_Fertilizers
        Main_Menu.panel_Main_Menu.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Main_Menu.panel_Main_Menu.Controls.Clear()

        Dim obj = New uc__Compound_Fertilizers
        Main_Menu.panel_Main_Menu.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Main_Menu.panel_Main_Menu.Controls.Clear()

        Dim obj = New uc_Complete_Fertilizer__NPK_
        obj.Location = New System.Drawing.Point(x, y)
        Main_Menu.panel_Main_Menu.Controls.Add(obj)

    End Sub
End Class
