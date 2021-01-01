<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Add_New_User
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Confirm_Pass = New System.Windows.Forms.TextBox()
        Me.lbl_Confo_Pass = New System.Windows.Forms.Label()
        Me.lbl_User_Name = New System.Windows.Forms.Label()
        Me.txt_Usr_Name = New System.Windows.Forms.TextBox()
        Me.lbl_Enter_Pass = New System.Windows.Forms.Label()
        Me.txt_Enter_Pass = New System.Windows.Forms.TextBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btn_Close)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1061, 47)
        Me.Panel1.TabIndex = 4
        '
        'btn_Close
        '
        Me.btn_Close.BackColor = System.Drawing.Color.White
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Close.FlatAppearance.BorderSize = 0
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Image = Global.E_krushi_Seva_Kendra.My.Resources.Resources.Close_2_icon
        Me.btn_Close.Location = New System.Drawing.Point(998, 0)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(63, 47)
        Me.btn_Close.TabIndex = 2
        Me.btn_Close.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(434, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New User"
        '
        'txt_Confirm_Pass
        '
        Me.txt_Confirm_Pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Confirm_Pass.Location = New System.Drawing.Point(528, 345)
        Me.txt_Confirm_Pass.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Confirm_Pass.MaxLength = 10
        Me.txt_Confirm_Pass.Name = "txt_Confirm_Pass"
        Me.txt_Confirm_Pass.Size = New System.Drawing.Size(320, 29)
        Me.txt_Confirm_Pass.TabIndex = 106
        '
        'lbl_Confo_Pass
        '
        Me.lbl_Confo_Pass.AutoSize = True
        Me.lbl_Confo_Pass.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Confo_Pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Confo_Pass.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Confo_Pass.Location = New System.Drawing.Point(240, 345)
        Me.lbl_Confo_Pass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Confo_Pass.Name = "lbl_Confo_Pass"
        Me.lbl_Confo_Pass.Size = New System.Drawing.Size(236, 31)
        Me.lbl_Confo_Pass.TabIndex = 109
        Me.lbl_Confo_Pass.Text = "Confirm Password"
        '
        'lbl_User_Name
        '
        Me.lbl_User_Name.AutoSize = True
        Me.lbl_User_Name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_User_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_User_Name.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_User_Name.Location = New System.Drawing.Point(278, 129)
        Me.lbl_User_Name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_User_Name.Name = "lbl_User_Name"
        Me.lbl_User_Name.Size = New System.Drawing.Size(151, 31)
        Me.lbl_User_Name.TabIndex = 107
        Me.lbl_User_Name.Text = "User Name"
        '
        'txt_Usr_Name
        '
        Me.txt_Usr_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Usr_Name.Location = New System.Drawing.Point(528, 129)
        Me.txt_Usr_Name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Usr_Name.MaxLength = 10
        Me.txt_Usr_Name.Name = "txt_Usr_Name"
        Me.txt_Usr_Name.Size = New System.Drawing.Size(320, 29)
        Me.txt_Usr_Name.TabIndex = 104
        '
        'lbl_Enter_Pass
        '
        Me.lbl_Enter_Pass.AutoSize = True
        Me.lbl_Enter_Pass.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Enter_Pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Enter_Pass.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Enter_Pass.Location = New System.Drawing.Point(251, 240)
        Me.lbl_Enter_Pass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Enter_Pass.Name = "lbl_Enter_Pass"
        Me.lbl_Enter_Pass.Size = New System.Drawing.Size(206, 31)
        Me.lbl_Enter_Pass.TabIndex = 108
        Me.lbl_Enter_Pass.Text = "Enter Password"
        '
        'txt_Enter_Pass
        '
        Me.txt_Enter_Pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Enter_Pass.Location = New System.Drawing.Point(528, 237)
        Me.txt_Enter_Pass.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Enter_Pass.MaxLength = 10
        Me.txt_Enter_Pass.Name = "txt_Enter_Pass"
        Me.txt_Enter_Pass.Size = New System.Drawing.Size(320, 29)
        Me.txt_Enter_Pass.TabIndex = 105
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.DimGray
        Me.btn_Save.Enabled = False
        Me.btn_Save.FlatAppearance.BorderSize = 0
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Font = New System.Drawing.Font("Sitka Small", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.ForeColor = System.Drawing.Color.White
        Me.btn_Save.Location = New System.Drawing.Point(315, 441)
        Me.btn_Save.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(236, 51)
        Me.btn_Save.TabIndex = 152
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.DimGray
        Me.btn_clear.Enabled = False
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Sitka Small", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.White
        Me.btn_clear.Location = New System.Drawing.Point(567, 441)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(216, 51)
        Me.btn_clear.TabIndex = 151
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Image = Global.E_krushi_Seva_Kendra.My.Resources.Resources.gettyimages_923212310_2048x2048
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1061, 723)
        Me.PictureBox1.TabIndex = 153
        Me.PictureBox1.TabStop = False
        '
        'uc_Add_New_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.txt_Confirm_Pass)
        Me.Controls.Add(Me.lbl_Confo_Pass)
        Me.Controls.Add(Me.lbl_User_Name)
        Me.Controls.Add(Me.txt_Usr_Name)
        Me.Controls.Add(Me.lbl_Enter_Pass)
        Me.Controls.Add(Me.txt_Enter_Pass)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "uc_Add_New_User"
        Me.Size = New System.Drawing.Size(1061, 723)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents txt_Confirm_Pass As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Confo_Pass As System.Windows.Forms.Label
    Friend WithEvents lbl_User_Name As System.Windows.Forms.Label
    Friend WithEvents txt_Usr_Name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Enter_Pass As System.Windows.Forms.Label
    Friend WithEvents txt_Enter_Pass As System.Windows.Forms.TextBox
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
