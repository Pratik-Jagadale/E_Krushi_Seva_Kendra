<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Update_Product
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
        Me.cmb_Category = New System.Windows.Forms.ComboBox()
        Me.txt_GST_Applied = New System.Windows.Forms.TextBox()
        Me.lbl_Specification = New System.Windows.Forms.Label()
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
        Me.btn_Update = New System.Windows.Forms.Button()
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
        Me.Label1.Location = New System.Drawing.Point(434, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Product"
        '
        'btn_Search
        '
        Me.btn_Search.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Search.Enabled = False
        Me.btn_Search.FlatAppearance.BorderSize = 0
        Me.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.Color.White
        Me.btn_Search.Location = New System.Drawing.Point(469, 86)
        Me.btn_Search.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(111, 38)
        Me.btn_Search.TabIndex = 106
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'cmb_Category
        '
        Me.cmb_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmb_Category.FormattingEnabled = True
        Me.cmb_Category.Items.AddRange(New Object() {"Grocery", "Stationary"})
        Me.cmb_Category.Location = New System.Drawing.Point(240, 291)
        Me.cmb_Category.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_Category.Name = "cmb_Category"
        Me.cmb_Category.Size = New System.Drawing.Size(209, 32)
        Me.cmb_Category.TabIndex = 108
        '
        'txt_GST_Applied
        '
        Me.txt_GST_Applied.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_GST_Applied.Location = New System.Drawing.Point(813, 296)
        Me.txt_GST_Applied.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_GST_Applied.Name = "txt_GST_Applied"
        Me.txt_GST_Applied.Size = New System.Drawing.Size(208, 29)
        Me.txt_GST_Applied.TabIndex = 113
        '
        'lbl_Specification
        '
        Me.lbl_Specification.AutoSize = True
        Me.lbl_Specification.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Specification.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Specification.Location = New System.Drawing.Point(588, 495)
        Me.lbl_Specification.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Specification.Name = "lbl_Specification"
        Me.lbl_Specification.Size = New System.Drawing.Size(120, 25)
        Me.lbl_Specification.TabIndex = 125
        Me.lbl_Specification.Text = "Description"
        '
        'txt_Stock_Added
        '
        Me.txt_Stock_Added.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Stock_Added.Location = New System.Drawing.Point(240, 495)
        Me.txt_Stock_Added.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Stock_Added.Name = "txt_Stock_Added"
        Me.txt_Stock_Added.Size = New System.Drawing.Size(213, 29)
        Me.txt_Stock_Added.TabIndex = 110
        '
        'lbl_Stock_Added
        '
        Me.lbl_Stock_Added.AutoSize = True
        Me.lbl_Stock_Added.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Stock_Added.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Stock_Added.Location = New System.Drawing.Point(31, 495)
        Me.lbl_Stock_Added.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Stock_Added.Name = "lbl_Stock_Added"
        Me.lbl_Stock_Added.Size = New System.Drawing.Size(134, 25)
        Me.lbl_Stock_Added.TabIndex = 124
        Me.lbl_Stock_Added.Text = "Stock Added"
        '
        'txt_Description
        '
        Me.txt_Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Description.Location = New System.Drawing.Point(813, 480)
        Me.txt_Description.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Description.Multiline = True
        Me.txt_Description.Name = "txt_Description"
        Me.txt_Description.Size = New System.Drawing.Size(208, 83)
        Me.txt_Description.TabIndex = 115
        '
        'lbl_Sales_Rate
        '
        Me.lbl_Sales_Rate.AutoSize = True
        Me.lbl_Sales_Rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Sales_Rate.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Sales_Rate.Location = New System.Drawing.Point(588, 385)
        Me.lbl_Sales_Rate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Sales_Rate.Name = "lbl_Sales_Rate"
        Me.lbl_Sales_Rate.Size = New System.Drawing.Size(117, 25)
        Me.lbl_Sales_Rate.TabIndex = 123
        Me.lbl_Sales_Rate.Text = "Sales Rate"
        '
        'lbl_GST_Applied
        '
        Me.lbl_GST_Applied.AutoSize = True
        Me.lbl_GST_Applied.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_GST_Applied.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_GST_Applied.Location = New System.Drawing.Point(582, 298)
        Me.lbl_GST_Applied.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_GST_Applied.Name = "lbl_GST_Applied"
        Me.lbl_GST_Applied.Size = New System.Drawing.Size(133, 25)
        Me.lbl_GST_Applied.TabIndex = 122
        Me.lbl_GST_Applied.Text = "GST Applied"
        '
        'txt_Purchase_Rate
        '
        Me.txt_Purchase_Rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Purchase_Rate.Location = New System.Drawing.Point(236, 398)
        Me.txt_Purchase_Rate.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Purchase_Rate.Name = "txt_Purchase_Rate"
        Me.txt_Purchase_Rate.Size = New System.Drawing.Size(213, 29)
        Me.txt_Purchase_Rate.TabIndex = 109
        '
        'lbl_Purchase_Rate
        '
        Me.lbl_Purchase_Rate.AutoSize = True
        Me.lbl_Purchase_Rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Purchase_Rate.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Purchase_Rate.Location = New System.Drawing.Point(25, 402)
        Me.lbl_Purchase_Rate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Purchase_Rate.Name = "lbl_Purchase_Rate"
        Me.lbl_Purchase_Rate.Size = New System.Drawing.Size(154, 25)
        Me.lbl_Purchase_Rate.TabIndex = 121
        Me.lbl_Purchase_Rate.Text = "Purchase Rate"
        '
        'lbl_Category
        '
        Me.lbl_Category.AutoSize = True
        Me.lbl_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Category.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Category.Location = New System.Drawing.Point(44, 298)
        Me.lbl_Category.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Category.Name = "lbl_Category"
        Me.lbl_Category.Size = New System.Drawing.Size(99, 25)
        Me.lbl_Category.TabIndex = 120
        Me.lbl_Category.Text = "Category"
        '
        'dtp_Stock_Date
        '
        Me.dtp_Stock_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.dtp_Stock_Date.Location = New System.Drawing.Point(811, 182)
        Me.dtp_Stock_Date.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_Stock_Date.Name = "dtp_Stock_Date"
        Me.dtp_Stock_Date.Size = New System.Drawing.Size(208, 29)
        Me.dtp_Stock_Date.TabIndex = 111
        '
        'txt_Sales_Rate
        '
        Me.txt_Sales_Rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Sales_Rate.Location = New System.Drawing.Point(811, 385)
        Me.txt_Sales_Rate.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Sales_Rate.Name = "txt_Sales_Rate"
        Me.txt_Sales_Rate.Size = New System.Drawing.Size(208, 29)
        Me.txt_Sales_Rate.TabIndex = 114
        '
        'lbl_Product_Id
        '
        Me.lbl_Product_Id.AutoSize = True
        Me.lbl_Product_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Product_Id.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Product_Id.Location = New System.Drawing.Point(31, 96)
        Me.lbl_Product_Id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Product_Id.Name = "lbl_Product_Id"
        Me.lbl_Product_Id.Size = New System.Drawing.Size(112, 25)
        Me.lbl_Product_Id.TabIndex = 116
        Me.lbl_Product_Id.Text = "Product ID"
        '
        'txt_Product_Id
        '
        Me.txt_Product_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Product_Id.Location = New System.Drawing.Point(236, 92)
        Me.txt_Product_Id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Product_Id.Name = "txt_Product_Id"
        Me.txt_Product_Id.Size = New System.Drawing.Size(213, 29)
        Me.txt_Product_Id.TabIndex = 105
        '
        'lbl_1s_Stock_Date
        '
        Me.lbl_1s_Stock_Date.AutoSize = True
        Me.lbl_1s_Stock_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_1s_Stock_Date.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_1s_Stock_Date.Location = New System.Drawing.Point(582, 194)
        Me.lbl_1s_Stock_Date.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_1s_Stock_Date.Name = "lbl_1s_Stock_Date"
        Me.lbl_1s_Stock_Date.Size = New System.Drawing.Size(146, 25)
        Me.lbl_1s_Stock_Date.TabIndex = 118
        Me.lbl_1s_Stock_Date.Text = "1s Stock Date"
        '
        'lbl_Product_Name
        '
        Me.lbl_Product_Name.AutoSize = True
        Me.lbl_Product_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Product_Name.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Product_Name.Location = New System.Drawing.Point(31, 198)
        Me.lbl_Product_Name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Product_Name.Name = "lbl_Product_Name"
        Me.lbl_Product_Name.Size = New System.Drawing.Size(148, 25)
        Me.lbl_Product_Name.TabIndex = 117
        Me.lbl_Product_Name.Text = "Product Name"
        '
        'txt_Product_Name
        '
        Me.txt_Product_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Product_Name.Location = New System.Drawing.Point(236, 194)
        Me.txt_Product_Name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Product_Name.Name = "txt_Product_Name"
        Me.txt_Product_Name.Size = New System.Drawing.Size(213, 29)
        Me.txt_Product_Name.TabIndex = 107
        '
        'btn_Update
        '
        Me.btn_Update.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Update.FlatAppearance.BorderSize = 0
        Me.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.ForeColor = System.Drawing.Color.White
        Me.btn_Update.Location = New System.Drawing.Point(455, 627)
        Me.btn_Update.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(158, 39)
        Me.btn_Update.TabIndex = 126
        Me.btn_Update.Text = "Update"
        Me.btn_Update.UseVisualStyleBackColor = False
        '
        'uc_Update_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.cmb_Category)
        Me.Controls.Add(Me.txt_GST_Applied)
        Me.Controls.Add(Me.lbl_Specification)
        Me.Controls.Add(Me.txt_Stock_Added)
        Me.Controls.Add(Me.lbl_Stock_Added)
        Me.Controls.Add(Me.txt_Description)
        Me.Controls.Add(Me.lbl_Sales_Rate)
        Me.Controls.Add(Me.lbl_GST_Applied)
        Me.Controls.Add(Me.txt_Purchase_Rate)
        Me.Controls.Add(Me.lbl_Purchase_Rate)
        Me.Controls.Add(Me.lbl_Category)
        Me.Controls.Add(Me.dtp_Stock_Date)
        Me.Controls.Add(Me.txt_Sales_Rate)
        Me.Controls.Add(Me.lbl_Product_Id)
        Me.Controls.Add(Me.txt_Product_Id)
        Me.Controls.Add(Me.lbl_1s_Stock_Date)
        Me.Controls.Add(Me.lbl_Product_Name)
        Me.Controls.Add(Me.txt_Product_Name)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_Update_Product"
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
    Friend WithEvents cmb_Category As System.Windows.Forms.ComboBox
    Friend WithEvents txt_GST_Applied As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Specification As System.Windows.Forms.Label
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
    Friend WithEvents btn_Update As System.Windows.Forms.Button

End Class
