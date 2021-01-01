<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Change_Password
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
        Me.btn_Update_Pass = New System.Windows.Forms.Button()
        Me.txt_New_Pass = New System.Windows.Forms.TextBox()
        Me.lbl_New_Pass = New System.Windows.Forms.Label()
        Me.lbl_Uname = New System.Windows.Forms.Label()
        Me.txt_Uname = New System.Windows.Forms.TextBox()
        Me.lbl_Current_Password = New System.Windows.Forms.Label()
        Me.txt_Current_Password = New System.Windows.Forms.TextBox()
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
        Me.Label1.Size = New System.Drawing.Size(271, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Change Password"
        '
        'btn_Update_Pass
        '
        Me.btn_Update_Pass.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Update_Pass.FlatAppearance.BorderSize = 0
        Me.btn_Update_Pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Update_Pass.Font = New System.Drawing.Font("Sitka Small", 20.25!, System.Drawing.FontStyle.Bold)
        Me.btn_Update_Pass.ForeColor = System.Drawing.Color.White
        Me.btn_Update_Pass.Location = New System.Drawing.Point(425, 520)
        Me.btn_Update_Pass.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Update_Pass.Name = "btn_Update_Pass"
        Me.btn_Update_Pass.Size = New System.Drawing.Size(258, 54)
        Me.btn_Update_Pass.TabIndex = 165
        Me.btn_Update_Pass.Text = "Update Password"
        Me.btn_Update_Pass.UseVisualStyleBackColor = False
        '
        'txt_New_Pass
        '
        Me.txt_New_Pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_New_Pass.Location = New System.Drawing.Point(556, 385)
        Me.txt_New_Pass.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_New_Pass.Name = "txt_New_Pass"
        Me.txt_New_Pass.Size = New System.Drawing.Size(357, 29)
        Me.txt_New_Pass.TabIndex = 161
        '
        'lbl_New_Pass
        '
        Me.lbl_New_Pass.AutoSize = True
        Me.lbl_New_Pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_New_Pass.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_New_Pass.Location = New System.Drawing.Point(221, 385)
        Me.lbl_New_Pass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_New_Pass.Name = "lbl_New_Pass"
        Me.lbl_New_Pass.Size = New System.Drawing.Size(209, 33)
        Me.lbl_New_Pass.TabIndex = 164
        Me.lbl_New_Pass.Text = "New Password"
        '
        'lbl_Uname
        '
        Me.lbl_Uname.AutoSize = True
        Me.lbl_Uname.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Uname.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Uname.Location = New System.Drawing.Point(221, 173)
        Me.lbl_Uname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Uname.Name = "lbl_Uname"
        Me.lbl_Uname.Size = New System.Drawing.Size(150, 33)
        Me.lbl_Uname.TabIndex = 162
        Me.lbl_Uname.Text = "Username"
        '
        'txt_Uname
        '
        Me.txt_Uname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Uname.Location = New System.Drawing.Point(556, 173)
        Me.txt_Uname.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Uname.Name = "txt_Uname"
        Me.txt_Uname.Size = New System.Drawing.Size(357, 29)
        Me.txt_Uname.TabIndex = 159
        '
        'lbl_Current_Password
        '
        Me.lbl_Current_Password.AutoSize = True
        Me.lbl_Current_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Current_Password.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Current_Password.Location = New System.Drawing.Point(192, 277)
        Me.lbl_Current_Password.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Current_Password.Name = "lbl_Current_Password"
        Me.lbl_Current_Password.Size = New System.Drawing.Size(248, 33)
        Me.lbl_Current_Password.TabIndex = 163
        Me.lbl_Current_Password.Text = "Current Password"
        '
        'txt_Current_Password
        '
        Me.txt_Current_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Current_Password.Location = New System.Drawing.Point(556, 277)
        Me.txt_Current_Password.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Current_Password.Name = "txt_Current_Password"
        Me.txt_Current_Password.Size = New System.Drawing.Size(357, 29)
        Me.txt_Current_Password.TabIndex = 160
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.E_krushi_Seva_Kendra.My.Resources.Resources.gettyimages_923212310_2048x2048
        Me.PictureBox1.Location = New System.Drawing.Point(0, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1061, 723)
        Me.PictureBox1.TabIndex = 166
        Me.PictureBox1.TabStop = False
        '
        'uc_Change_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_Update_Pass)
        Me.Controls.Add(Me.txt_New_Pass)
        Me.Controls.Add(Me.lbl_New_Pass)
        Me.Controls.Add(Me.lbl_Uname)
        Me.Controls.Add(Me.txt_Uname)
        Me.Controls.Add(Me.lbl_Current_Password)
        Me.Controls.Add(Me.txt_Current_Password)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "uc_Change_Password"
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
    Friend WithEvents btn_Update_Pass As System.Windows.Forms.Button
    Friend WithEvents txt_New_Pass As System.Windows.Forms.TextBox
    Friend WithEvents lbl_New_Pass As System.Windows.Forms.Label
    Friend WithEvents lbl_Uname As System.Windows.Forms.Label
    Friend WithEvents txt_Uname As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Current_Password As System.Windows.Forms.Label
    Friend WithEvents txt_Current_Password As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
