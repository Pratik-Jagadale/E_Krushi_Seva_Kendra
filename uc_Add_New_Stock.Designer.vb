<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Add_New_Stock
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
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.lbl_Current_Stock = New System.Windows.Forms.Label()
        Me.txt_Stock_Added = New System.Windows.Forms.TextBox()
        Me.lbl_Stock_Added = New System.Windows.Forms.Label()
        Me.txt_Current_Stock = New System.Windows.Forms.TextBox()
        Me.txt_Category = New System.Windows.Forms.TextBox()
        Me.dtp_Stock_Add_Date = New System.Windows.Forms.DateTimePicker()
        Me.txt_Product_Name = New System.Windows.Forms.TextBox()
        Me.btn_Update_Stock = New System.Windows.Forms.Button()
        Me.lbl_Product_Id = New System.Windows.Forms.Label()
        Me.lbl_Category = New System.Windows.Forms.Label()
        Me.lbl_Product_Name = New System.Windows.Forms.Label()
        Me.txt_Product_Id = New System.Windows.Forms.TextBox()
        Me.lbl_Stock_Add_Date = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
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
        Me.Label1.Location = New System.Drawing.Point(463, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Stock"
        '
        'btn_Search
        '
        Me.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Search.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Search.FlatAppearance.BorderSize = 0
        Me.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.Color.White
        Me.btn_Search.Location = New System.Drawing.Point(724, 173)
        Me.btn_Search.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(133, 38)
        Me.btn_Search.TabIndex = 122
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'lbl_Current_Stock
        '
        Me.lbl_Current_Stock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_Current_Stock.AutoSize = True
        Me.lbl_Current_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Current_Stock.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Current_Stock.Location = New System.Drawing.Point(339, 424)
        Me.lbl_Current_Stock.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Current_Stock.Name = "lbl_Current_Stock"
        Me.lbl_Current_Stock.Size = New System.Drawing.Size(143, 25)
        Me.lbl_Current_Stock.TabIndex = 133
        Me.lbl_Current_Stock.Text = "Current Stock"
        '
        'txt_Stock_Added
        '
        Me.txt_Stock_Added.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Stock_Added.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Stock_Added.Location = New System.Drawing.Point(566, 512)
        Me.txt_Stock_Added.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Stock_Added.MaxLength = 5
        Me.txt_Stock_Added.Name = "txt_Stock_Added"
        Me.txt_Stock_Added.Size = New System.Drawing.Size(198, 29)
        Me.txt_Stock_Added.TabIndex = 123
        '
        'lbl_Stock_Added
        '
        Me.lbl_Stock_Added.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_Stock_Added.AutoSize = True
        Me.lbl_Stock_Added.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Stock_Added.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Stock_Added.Location = New System.Drawing.Point(339, 516)
        Me.lbl_Stock_Added.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Stock_Added.Name = "lbl_Stock_Added"
        Me.lbl_Stock_Added.Size = New System.Drawing.Size(134, 25)
        Me.lbl_Stock_Added.TabIndex = 134
        Me.lbl_Stock_Added.Text = "Stock Added"
        '
        'txt_Current_Stock
        '
        Me.txt_Current_Stock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Current_Stock.Enabled = False
        Me.txt_Current_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Current_Stock.Location = New System.Drawing.Point(566, 422)
        Me.txt_Current_Stock.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Current_Stock.Name = "txt_Current_Stock"
        Me.txt_Current_Stock.Size = New System.Drawing.Size(198, 29)
        Me.txt_Current_Stock.TabIndex = 128
        '
        'txt_Category
        '
        Me.txt_Category.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Category.Enabled = False
        Me.txt_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Category.Location = New System.Drawing.Point(710, 297)
        Me.txt_Category.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Category.Name = "txt_Category"
        Me.txt_Category.Size = New System.Drawing.Size(294, 29)
        Me.txt_Category.TabIndex = 127
        '
        'dtp_Stock_Add_Date
        '
        Me.dtp_Stock_Add_Date.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtp_Stock_Add_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.dtp_Stock_Add_Date.Location = New System.Drawing.Point(794, 85)
        Me.dtp_Stock_Add_Date.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_Stock_Add_Date.Name = "dtp_Stock_Add_Date"
        Me.dtp_Stock_Add_Date.Size = New System.Drawing.Size(190, 29)
        Me.dtp_Stock_Add_Date.TabIndex = 126
        '
        'txt_Product_Name
        '
        Me.txt_Product_Name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Product_Name.Enabled = False
        Me.txt_Product_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Product_Name.Location = New System.Drawing.Point(255, 301)
        Me.txt_Product_Name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Product_Name.Name = "txt_Product_Name"
        Me.txt_Product_Name.Size = New System.Drawing.Size(278, 29)
        Me.txt_Product_Name.TabIndex = 125
        '
        'btn_Update_Stock
        '
        Me.btn_Update_Stock.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Update_Stock.FlatAppearance.BorderSize = 0
        Me.btn_Update_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Update_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update_Stock.ForeColor = System.Drawing.Color.White
        Me.btn_Update_Stock.Location = New System.Drawing.Point(395, 585)
        Me.btn_Update_Stock.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Update_Stock.Name = "btn_Update_Stock"
        Me.btn_Update_Stock.Size = New System.Drawing.Size(223, 46)
        Me.btn_Update_Stock.TabIndex = 124
        Me.btn_Update_Stock.Text = "Update Stock"
        Me.btn_Update_Stock.UseVisualStyleBackColor = False
        '
        'lbl_Product_Id
        '
        Me.lbl_Product_Id.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_Product_Id.AutoSize = True
        Me.lbl_Product_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Product_Id.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Product_Id.Location = New System.Drawing.Point(249, 180)
        Me.lbl_Product_Id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Product_Id.Name = "lbl_Product_Id"
        Me.lbl_Product_Id.Size = New System.Drawing.Size(112, 25)
        Me.lbl_Product_Id.TabIndex = 129
        Me.lbl_Product_Id.Text = "Product ID"
        '
        'lbl_Category
        '
        Me.lbl_Category.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_Category.AutoSize = True
        Me.lbl_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Category.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Category.Location = New System.Drawing.Point(572, 301)
        Me.lbl_Category.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Category.Name = "lbl_Category"
        Me.lbl_Category.Size = New System.Drawing.Size(99, 25)
        Me.lbl_Category.TabIndex = 132
        Me.lbl_Category.Text = "Category"
        '
        'lbl_Product_Name
        '
        Me.lbl_Product_Name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_Product_Name.AutoSize = True
        Me.lbl_Product_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Product_Name.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Product_Name.Location = New System.Drawing.Point(24, 308)
        Me.lbl_Product_Name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Product_Name.Name = "lbl_Product_Name"
        Me.lbl_Product_Name.Size = New System.Drawing.Size(148, 25)
        Me.lbl_Product_Name.TabIndex = 130
        Me.lbl_Product_Name.Text = "Product Name"
        '
        'txt_Product_Id
        '
        Me.txt_Product_Id.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Product_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Product_Id.Location = New System.Drawing.Point(426, 173)
        Me.txt_Product_Id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Product_Id.MaxLength = 5
        Me.txt_Product_Id.Name = "txt_Product_Id"
        Me.txt_Product_Id.Size = New System.Drawing.Size(233, 29)
        Me.txt_Product_Id.TabIndex = 121
        '
        'lbl_Stock_Add_Date
        '
        Me.lbl_Stock_Add_Date.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_Stock_Add_Date.AutoSize = True
        Me.lbl_Stock_Add_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Stock_Add_Date.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Stock_Add_Date.Location = New System.Drawing.Point(629, 85)
        Me.lbl_Stock_Add_Date.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Stock_Add_Date.Name = "lbl_Stock_Add_Date"
        Me.lbl_Stock_Add_Date.Size = New System.Drawing.Size(161, 25)
        Me.lbl_Stock_Add_Date.TabIndex = 131
        Me.lbl_Stock_Add_Date.Text = "Stock Add Date"
        '
        'uc_Add_New_Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.lbl_Current_Stock)
        Me.Controls.Add(Me.txt_Stock_Added)
        Me.Controls.Add(Me.lbl_Stock_Added)
        Me.Controls.Add(Me.txt_Current_Stock)
        Me.Controls.Add(Me.txt_Category)
        Me.Controls.Add(Me.dtp_Stock_Add_Date)
        Me.Controls.Add(Me.txt_Product_Name)
        Me.Controls.Add(Me.btn_Update_Stock)
        Me.Controls.Add(Me.lbl_Product_Id)
        Me.Controls.Add(Me.lbl_Category)
        Me.Controls.Add(Me.lbl_Product_Name)
        Me.Controls.Add(Me.txt_Product_Id)
        Me.Controls.Add(Me.lbl_Stock_Add_Date)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_Add_New_Stock"
        Me.Size = New System.Drawing.Size(1061, 723)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents lbl_Current_Stock As System.Windows.Forms.Label
    Friend WithEvents txt_Stock_Added As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Stock_Added As System.Windows.Forms.Label
    Friend WithEvents txt_Current_Stock As System.Windows.Forms.TextBox
    Friend WithEvents txt_Category As System.Windows.Forms.TextBox
    Friend WithEvents dtp_Stock_Add_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Product_Name As System.Windows.Forms.TextBox
    Friend WithEvents btn_Update_Stock As System.Windows.Forms.Button
    Friend WithEvents lbl_Product_Id As System.Windows.Forms.Label
    Friend WithEvents lbl_Category As System.Windows.Forms.Label
    Friend WithEvents lbl_Product_Name As System.Windows.Forms.Label
    Friend WithEvents txt_Product_Id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Stock_Add_Date As System.Windows.Forms.Label

End Class
