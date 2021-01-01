<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Add_New_Product
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.cmb_Category = New System.Windows.Forms.ComboBox()
        Me.txt_GST_Applied = New System.Windows.Forms.TextBox()
        Me.lbl_Description = New System.Windows.Forms.Label()
        Me.txt_Stock_Added = New System.Windows.Forms.TextBox()
        Me.lbl_Stock_Added = New System.Windows.Forms.Label()
        Me.txt_Description = New System.Windows.Forms.TextBox()
        Me.lbl_Sales_Rate = New System.Windows.Forms.Label()
        Me.lbl_GST_Applied = New System.Windows.Forms.Label()
        Me.txt_Purchase_Rate = New System.Windows.Forms.TextBox()
        Me.lbl_Purchase_Rate = New System.Windows.Forms.Label()
        Me.lbl_Category = New System.Windows.Forms.Label()
        Me.dtp_Stock_Date = New System.Windows.Forms.DateTimePicker()
        Me.txt_Sales_Rate = New System.Windows.Forms.TextBox()
        Me.lbl_Product_Id = New System.Windows.Forms.Label()
        Me.txt_Product_Id = New System.Windows.Forms.TextBox()
        Me.lbl_1s_Stock_Date = New System.Windows.Forms.Label()
        Me.lbl_Product_Name = New System.Windows.Forms.Label()
        Me.txt_Product_Name = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Panel1.TabIndex = 3
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
        Me.Label1.Location = New System.Drawing.Point(425, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New Product"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_Save)
        Me.Panel2.Controls.Add(Me.cmb_Category)
        Me.Panel2.Controls.Add(Me.txt_GST_Applied)
        Me.Panel2.Controls.Add(Me.lbl_Description)
        Me.Panel2.Controls.Add(Me.txt_Stock_Added)
        Me.Panel2.Controls.Add(Me.lbl_Stock_Added)
        Me.Panel2.Controls.Add(Me.txt_Description)
        Me.Panel2.Controls.Add(Me.lbl_Sales_Rate)
        Me.Panel2.Controls.Add(Me.lbl_GST_Applied)
        Me.Panel2.Controls.Add(Me.txt_Purchase_Rate)
        Me.Panel2.Controls.Add(Me.lbl_Purchase_Rate)
        Me.Panel2.Controls.Add(Me.lbl_Category)
        Me.Panel2.Controls.Add(Me.dtp_Stock_Date)
        Me.Panel2.Controls.Add(Me.txt_Sales_Rate)
        Me.Panel2.Controls.Add(Me.lbl_Product_Id)
        Me.Panel2.Controls.Add(Me.txt_Product_Id)
        Me.Panel2.Controls.Add(Me.lbl_1s_Stock_Date)
        Me.Panel2.Controls.Add(Me.lbl_Product_Name)
        Me.Panel2.Controls.Add(Me.txt_Product_Name)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1061, 631)
        Me.Panel2.TabIndex = 4
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Save.FlatAppearance.BorderSize = 0
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.ForeColor = System.Drawing.Color.White
        Me.btn_Save.Location = New System.Drawing.Point(400, 544)
        Me.btn_Save.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(186, 44)
        Me.btn_Save.TabIndex = 144
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'cmb_Category
        '
        Me.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmb_Category.FormattingEnabled = True
        Me.cmb_Category.Items.AddRange(New Object() {"A", "B"})
        Me.cmb_Category.Location = New System.Drawing.Point(197, 232)
        Me.cmb_Category.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_Category.Name = "cmb_Category"
        Me.cmb_Category.Size = New System.Drawing.Size(251, 32)
        Me.cmb_Category.TabIndex = 128
        '
        'txt_GST_Applied
        '
        Me.txt_GST_Applied.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_GST_Applied.ForeColor = System.Drawing.Color.DarkGreen
        Me.txt_GST_Applied.Location = New System.Drawing.Point(709, 133)
        Me.txt_GST_Applied.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_GST_Applied.Name = "txt_GST_Applied"
        Me.txt_GST_Applied.Size = New System.Drawing.Size(270, 29)
        Me.txt_GST_Applied.TabIndex = 132
        '
        'lbl_Description
        '
        Me.lbl_Description.AutoSize = True
        Me.lbl_Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Description.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Description.Location = New System.Drawing.Point(533, 325)
        Me.lbl_Description.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Description.Name = "lbl_Description"
        Me.lbl_Description.Size = New System.Drawing.Size(120, 25)
        Me.lbl_Description.TabIndex = 143
        Me.lbl_Description.Text = "Description"
        '
        'txt_Stock_Added
        '
        Me.txt_Stock_Added.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Stock_Added.Location = New System.Drawing.Point(197, 417)
        Me.txt_Stock_Added.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Stock_Added.Name = "txt_Stock_Added"
        Me.txt_Stock_Added.Size = New System.Drawing.Size(251, 29)
        Me.txt_Stock_Added.TabIndex = 130
        Me.txt_Stock_Added.Text = "0"
        Me.txt_Stock_Added.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Stock_Added
        '
        Me.lbl_Stock_Added.AutoSize = True
        Me.lbl_Stock_Added.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Stock_Added.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Stock_Added.Location = New System.Drawing.Point(33, 422)
        Me.lbl_Stock_Added.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Stock_Added.Name = "lbl_Stock_Added"
        Me.lbl_Stock_Added.Size = New System.Drawing.Size(134, 25)
        Me.lbl_Stock_Added.TabIndex = 142
        Me.lbl_Stock_Added.Text = "Stock Added"
        '
        'txt_Description
        '
        Me.txt_Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Description.Location = New System.Drawing.Point(709, 325)
        Me.txt_Description.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Description.Multiline = True
        Me.txt_Description.Name = "txt_Description"
        Me.txt_Description.Size = New System.Drawing.Size(270, 94)
        Me.txt_Description.TabIndex = 134
        '
        'lbl_Sales_Rate
        '
        Me.lbl_Sales_Rate.AutoSize = True
        Me.lbl_Sales_Rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Sales_Rate.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Sales_Rate.Location = New System.Drawing.Point(536, 231)
        Me.lbl_Sales_Rate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Sales_Rate.Name = "lbl_Sales_Rate"
        Me.lbl_Sales_Rate.Size = New System.Drawing.Size(117, 25)
        Me.lbl_Sales_Rate.TabIndex = 141
        Me.lbl_Sales_Rate.Text = "Sales Rate"
        '
        'lbl_GST_Applied
        '
        Me.lbl_GST_Applied.AutoSize = True
        Me.lbl_GST_Applied.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_GST_Applied.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_GST_Applied.Location = New System.Drawing.Point(533, 133)
        Me.lbl_GST_Applied.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_GST_Applied.Name = "lbl_GST_Applied"
        Me.lbl_GST_Applied.Size = New System.Drawing.Size(133, 25)
        Me.lbl_GST_Applied.TabIndex = 140
        Me.lbl_GST_Applied.Text = "GST Applied"
        '
        'txt_Purchase_Rate
        '
        Me.txt_Purchase_Rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Purchase_Rate.Location = New System.Drawing.Point(197, 326)
        Me.txt_Purchase_Rate.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Purchase_Rate.Name = "txt_Purchase_Rate"
        Me.txt_Purchase_Rate.Size = New System.Drawing.Size(251, 29)
        Me.txt_Purchase_Rate.TabIndex = 129
        '
        'lbl_Purchase_Rate
        '
        Me.lbl_Purchase_Rate.AutoSize = True
        Me.lbl_Purchase_Rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Purchase_Rate.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Purchase_Rate.Location = New System.Drawing.Point(33, 329)
        Me.lbl_Purchase_Rate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Purchase_Rate.Name = "lbl_Purchase_Rate"
        Me.lbl_Purchase_Rate.Size = New System.Drawing.Size(154, 25)
        Me.lbl_Purchase_Rate.TabIndex = 139
        Me.lbl_Purchase_Rate.Text = "Purchase Rate"
        '
        'lbl_Category
        '
        Me.lbl_Category.AutoSize = True
        Me.lbl_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Category.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Category.Location = New System.Drawing.Point(33, 241)
        Me.lbl_Category.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Category.Name = "lbl_Category"
        Me.lbl_Category.Size = New System.Drawing.Size(99, 25)
        Me.lbl_Category.TabIndex = 138
        Me.lbl_Category.Text = "Category"
        '
        'dtp_Stock_Date
        '
        Me.dtp_Stock_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.dtp_Stock_Date.Location = New System.Drawing.Point(709, 48)
        Me.dtp_Stock_Date.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_Stock_Date.Name = "dtp_Stock_Date"
        Me.dtp_Stock_Date.Size = New System.Drawing.Size(270, 29)
        Me.dtp_Stock_Date.TabIndex = 131
        '
        'txt_Sales_Rate
        '
        Me.txt_Sales_Rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Sales_Rate.Location = New System.Drawing.Point(709, 231)
        Me.txt_Sales_Rate.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Sales_Rate.Name = "txt_Sales_Rate"
        Me.txt_Sales_Rate.Size = New System.Drawing.Size(270, 29)
        Me.txt_Sales_Rate.TabIndex = 133
        '
        'lbl_Product_Id
        '
        Me.lbl_Product_Id.AutoSize = True
        Me.lbl_Product_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Product_Id.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Product_Id.Location = New System.Drawing.Point(33, 52)
        Me.lbl_Product_Id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Product_Id.Name = "lbl_Product_Id"
        Me.lbl_Product_Id.Size = New System.Drawing.Size(112, 25)
        Me.lbl_Product_Id.TabIndex = 135
        Me.lbl_Product_Id.Text = "Product ID"
        '
        'txt_Product_Id
        '
        Me.txt_Product_Id.Enabled = False
        Me.txt_Product_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Product_Id.Location = New System.Drawing.Point(197, 50)
        Me.txt_Product_Id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Product_Id.Name = "txt_Product_Id"
        Me.txt_Product_Id.Size = New System.Drawing.Size(251, 29)
        Me.txt_Product_Id.TabIndex = 126
        '
        'lbl_1s_Stock_Date
        '
        Me.lbl_1s_Stock_Date.AutoSize = True
        Me.lbl_1s_Stock_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_1s_Stock_Date.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_1s_Stock_Date.Location = New System.Drawing.Point(533, 52)
        Me.lbl_1s_Stock_Date.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_1s_Stock_Date.Name = "lbl_1s_Stock_Date"
        Me.lbl_1s_Stock_Date.Size = New System.Drawing.Size(152, 25)
        Me.lbl_1s_Stock_Date.TabIndex = 137
        Me.lbl_1s_Stock_Date.Text = "1st Stock Date"
        '
        'lbl_Product_Name
        '
        Me.lbl_Product_Name.AutoSize = True
        Me.lbl_Product_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Product_Name.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Product_Name.Location = New System.Drawing.Point(33, 153)
        Me.lbl_Product_Name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Product_Name.Name = "lbl_Product_Name"
        Me.lbl_Product_Name.Size = New System.Drawing.Size(148, 25)
        Me.lbl_Product_Name.TabIndex = 136
        Me.lbl_Product_Name.Text = "Product Name"
        '
        'txt_Product_Name
        '
        Me.txt_Product_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Product_Name.Location = New System.Drawing.Point(197, 141)
        Me.txt_Product_Name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Product_Name.Name = "txt_Product_Name"
        Me.txt_Product_Name.Size = New System.Drawing.Size(251, 29)
        Me.txt_Product_Name.TabIndex = 127
        '
        'uc_Add_New_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_Add_New_Product"
        Me.Size = New System.Drawing.Size(1061, 723)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents cmb_Category As System.Windows.Forms.ComboBox
    Friend WithEvents txt_GST_Applied As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Description As System.Windows.Forms.Label
    Friend WithEvents txt_Stock_Added As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Stock_Added As System.Windows.Forms.Label
    Friend WithEvents txt_Description As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Sales_Rate As System.Windows.Forms.Label
    Friend WithEvents lbl_GST_Applied As System.Windows.Forms.Label
    Friend WithEvents txt_Purchase_Rate As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Purchase_Rate As System.Windows.Forms.Label
    Friend WithEvents lbl_Category As System.Windows.Forms.Label
    Friend WithEvents dtp_Stock_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Sales_Rate As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Product_Id As System.Windows.Forms.Label
    Friend WithEvents txt_Product_Id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_1s_Stock_Date As System.Windows.Forms.Label
    Friend WithEvents lbl_Product_Name As System.Windows.Forms.Label
    Friend WithEvents txt_Product_Name As System.Windows.Forms.TextBox

End Class
