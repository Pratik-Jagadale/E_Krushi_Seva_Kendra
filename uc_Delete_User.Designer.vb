<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Delete_User
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
        Me.btn_Delete_User = New System.Windows.Forms.Button()
        Me.txt_Pwd = New System.Windows.Forms.TextBox()
        Me.lbl_Enter_Password = New System.Windows.Forms.Label()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.txt_U_Name = New System.Windows.Forms.TextBox()
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
        Me.btn_Close.TabIndex = 1
        Me.btn_Close.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(445, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Delete User"
        '
        'btn_Delete_User
        '
        Me.btn_Delete_User.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Delete_User.FlatAppearance.BorderSize = 0
        Me.btn_Delete_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Delete_User.Font = New System.Drawing.Font("Sitka Small", 20.25!, System.Drawing.FontStyle.Bold)
        Me.btn_Delete_User.ForeColor = System.Drawing.Color.White
        Me.btn_Delete_User.Location = New System.Drawing.Point(399, 454)
        Me.btn_Delete_User.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Delete_User.Name = "btn_Delete_User"
        Me.btn_Delete_User.Size = New System.Drawing.Size(246, 71)
        Me.btn_Delete_User.TabIndex = 162
        Me.btn_Delete_User.Text = "Delete User"
        Me.btn_Delete_User.UseVisualStyleBackColor = False
        '
        'txt_Pwd
        '
        Me.txt_Pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Pwd.Location = New System.Drawing.Point(542, 339)
        Me.txt_Pwd.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Pwd.Name = "txt_Pwd"
        Me.txt_Pwd.Size = New System.Drawing.Size(357, 29)
        Me.txt_Pwd.TabIndex = 159
        '
        'lbl_Enter_Password
        '
        Me.lbl_Enter_Password.AutoSize = True
        Me.lbl_Enter_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Enter_Password.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Enter_Password.Location = New System.Drawing.Point(226, 334)
        Me.lbl_Enter_Password.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Enter_Password.Name = "lbl_Enter_Password"
        Me.lbl_Enter_Password.Size = New System.Drawing.Size(220, 33)
        Me.lbl_Enter_Password.TabIndex = 161
        Me.lbl_Enter_Password.Text = "Enter Password"
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Username.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Username.Location = New System.Drawing.Point(257, 214)
        Me.lbl_Username.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(150, 33)
        Me.lbl_Username.TabIndex = 160
        Me.lbl_Username.Text = "Username"
        '
        'txt_U_Name
        '
        Me.txt_U_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_U_Name.Location = New System.Drawing.Point(542, 214)
        Me.txt_U_Name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_U_Name.Name = "txt_U_Name"
        Me.txt_U_Name.Size = New System.Drawing.Size(357, 29)
        Me.txt_U_Name.TabIndex = 158
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.E_krushi_Seva_Kendra.My.Resources.Resources.gettyimages_923212310_2048x2048
        Me.PictureBox1.Location = New System.Drawing.Point(0, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1061, 723)
        Me.PictureBox1.TabIndex = 163
        Me.PictureBox1.TabStop = False
        '
        'uc_Delete_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_Delete_User)
        Me.Controls.Add(Me.txt_Pwd)
        Me.Controls.Add(Me.lbl_Enter_Password)
        Me.Controls.Add(Me.lbl_Username)
        Me.Controls.Add(Me.txt_U_Name)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "uc_Delete_User"
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
    Friend WithEvents btn_Delete_User As System.Windows.Forms.Button
    Friend WithEvents txt_Pwd As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Enter_Password As System.Windows.Forms.Label
    Friend WithEvents lbl_Username As System.Windows.Forms.Label
    Friend WithEvents txt_U_Name As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
