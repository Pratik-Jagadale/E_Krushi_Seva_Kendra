<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Add_New_Customer
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Per = New System.Windows.Forms.Label()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.txt_Total_Bill = New System.Windows.Forms.TextBox()
        Me.txt_Discount = New System.Windows.Forms.TextBox()
        Me.Gpb_Purchase_Detail = New System.Windows.Forms.GroupBox()
        Me.tb_Product_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_Product_Name = New System.Windows.Forms.ComboBox()
        Me.lbl_Product_Name = New System.Windows.Forms.Label()
        Me.dgv_Customer_Purchase_Details = New System.Windows.Forms.DataGridView()
        Me.Cust_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Catagory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_Bill = New System.Windows.Forms.TextBox()
        Me.lbl_Total_Bill = New System.Windows.Forms.Label()
        Me.lbl_Discount = New System.Windows.Forms.Label()
        Me.lbl_Bill = New System.Windows.Forms.Label()
        Me.cmb_Product_catagory = New System.Windows.Forms.ComboBox()
        Me.txt_Total_Price = New System.Windows.Forms.TextBox()
        Me.txt_Quantity = New System.Windows.Forms.TextBox()
        Me.lbl_Total_Price = New System.Windows.Forms.Label()
        Me.lbl_Quantity = New System.Windows.Forms.Label()
        Me.lbl_Price = New System.Windows.Forms.Label()
        Me.lbl_GST = New System.Windows.Forms.Label()
        Me.txt_GST = New System.Windows.Forms.TextBox()
        Me.lbl_Product_Category = New System.Windows.Forms.Label()
        Me.txt_Price = New System.Windows.Forms.TextBox()
        Me.lbl_Customer_Id = New System.Windows.Forms.Label()
        Me.txt_Customer_Id = New System.Windows.Forms.TextBox()
        Me.lbl_Customer_Name = New System.Windows.Forms.Label()
        Me.txt_Customer_Name = New System.Windows.Forms.TextBox()
        Me.Gpb_Customer_Detail = New System.Windows.Forms.GroupBox()
        Me.lbl_Mobile_No = New System.Windows.Forms.Label()
        Me.lbl_Bill_Date = New System.Windows.Forms.Label()
        Me.dtp_Bill_Date = New System.Windows.Forms.DateTimePicker()
        Me.txt_Mob_No = New System.Windows.Forms.TextBox()
        Me.btn_Refresh = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Gpb_Purchase_Detail.SuspendLayout()
        CType(Me.dgv_Customer_Purchase_Details, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gpb_Customer_Detail.SuspendLayout()
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
        Me.Panel1.TabIndex = 0
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
        Me.Label1.Location = New System.Drawing.Point(410, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New Customer"
        '
        'lbl_Per
        '
        Me.lbl_Per.AutoSize = True
        Me.lbl_Per.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Per.Location = New System.Drawing.Point(633, 351)
        Me.lbl_Per.Name = "lbl_Per"
        Me.lbl_Per.Size = New System.Drawing.Size(30, 25)
        Me.lbl_Per.TabIndex = 146
        Me.lbl_Per.Text = "%"
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Add.FlatAppearance.BorderSize = 0
        Me.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.ForeColor = System.Drawing.Color.White
        Me.btn_Add.Location = New System.Drawing.Point(895, 95)
        Me.btn_Add.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(109, 38)
        Me.btn_Add.TabIndex = 133
        Me.btn_Add.Text = "Add"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'txt_Total_Bill
        '
        Me.txt_Total_Bill.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Total_Bill.Location = New System.Drawing.Point(820, 351)
        Me.txt_Total_Bill.Name = "txt_Total_Bill"
        Me.txt_Total_Bill.Size = New System.Drawing.Size(159, 29)
        Me.txt_Total_Bill.TabIndex = 136
        Me.txt_Total_Bill.Text = "0"
        '
        'txt_Discount
        '
        Me.txt_Discount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Discount.Location = New System.Drawing.Point(453, 351)
        Me.txt_Discount.Name = "txt_Discount"
        Me.txt_Discount.Size = New System.Drawing.Size(157, 29)
        Me.txt_Discount.TabIndex = 135
        Me.txt_Discount.Text = "0"
        '
        'Gpb_Purchase_Detail
        '
        Me.Gpb_Purchase_Detail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gpb_Purchase_Detail.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Gpb_Purchase_Detail.Controls.Add(Me.tb_Product_id)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.Label2)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.cmb_Product_Name)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.lbl_Product_Name)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.dgv_Customer_Purchase_Details)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.lbl_Per)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.btn_Add)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.txt_Total_Bill)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.txt_Discount)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.txt_Bill)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.lbl_Total_Bill)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.lbl_Discount)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.lbl_Bill)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.cmb_Product_catagory)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.txt_Total_Price)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.txt_Quantity)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.lbl_Total_Price)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.lbl_Quantity)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.lbl_Price)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.lbl_GST)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.txt_GST)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.lbl_Product_Category)
        Me.Gpb_Purchase_Detail.Controls.Add(Me.txt_Price)
        Me.Gpb_Purchase_Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gpb_Purchase_Detail.Location = New System.Drawing.Point(3, 224)
        Me.Gpb_Purchase_Detail.Margin = New System.Windows.Forms.Padding(2)
        Me.Gpb_Purchase_Detail.Name = "Gpb_Purchase_Detail"
        Me.Gpb_Purchase_Detail.Padding = New System.Windows.Forms.Padding(2)
        Me.Gpb_Purchase_Detail.Size = New System.Drawing.Size(1056, 391)
        Me.Gpb_Purchase_Detail.TabIndex = 19
        Me.Gpb_Purchase_Detail.TabStop = False
        Me.Gpb_Purchase_Detail.Text = "Purchase Detail"
        '
        'tb_Product_id
        '
        Me.tb_Product_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.tb_Product_id.Location = New System.Drawing.Point(107, 38)
        Me.tb_Product_id.Name = "tb_Product_id"
        Me.tb_Product_id.Size = New System.Drawing.Size(109, 29)
        Me.tb_Product_id.TabIndex = 151
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(10, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 25)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "P ID"
        '
        'cmb_Product_Name
        '
        Me.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmb_Product_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Product_Name.FormattingEnabled = True
        Me.cmb_Product_Name.Location = New System.Drawing.Point(661, 34)
        Me.cmb_Product_Name.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_Product_Name.Name = "cmb_Product_Name"
        Me.cmb_Product_Name.Size = New System.Drawing.Size(135, 33)
        Me.cmb_Product_Name.TabIndex = 149
        '
        'lbl_Product_Name
        '
        Me.lbl_Product_Name.AutoSize = True
        Me.lbl_Product_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Product_Name.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Product_Name.Location = New System.Drawing.Point(559, 39)
        Me.lbl_Product_Name.Name = "lbl_Product_Name"
        Me.lbl_Product_Name.Size = New System.Drawing.Size(88, 25)
        Me.lbl_Product_Name.TabIndex = 148
        Me.lbl_Product_Name.Text = "P Name"
        '
        'dgv_Customer_Purchase_Details
        '
        Me.dgv_Customer_Purchase_Details.AllowUserToAddRows = False
        Me.dgv_Customer_Purchase_Details.AllowUserToDeleteRows = False
        Me.dgv_Customer_Purchase_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Customer_Purchase_Details.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.HotPink
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Customer_Purchase_Details.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgv_Customer_Purchase_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Customer_Purchase_Details.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cust_ID, Me.Product_id, Me.Catagory, Me.Product_Name, Me.Unit_Price, Me.GST, Me.Quantity, Me.Total_Price})
        Me.dgv_Customer_Purchase_Details.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_Customer_Purchase_Details.Location = New System.Drawing.Point(-13, 142)
        Me.dgv_Customer_Purchase_Details.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_Customer_Purchase_Details.Name = "dgv_Customer_Purchase_Details"
        Me.dgv_Customer_Purchase_Details.ReadOnly = True
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Customer_Purchase_Details.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgv_Customer_Purchase_Details.RowTemplate.Height = 24
        Me.dgv_Customer_Purchase_Details.Size = New System.Drawing.Size(1028, 179)
        Me.dgv_Customer_Purchase_Details.TabIndex = 147
        '
        'Cust_ID
        '
        Me.Cust_ID.HeaderText = "Cust ID"
        Me.Cust_ID.Name = "Cust_ID"
        Me.Cust_ID.ReadOnly = True
        Me.Cust_ID.Visible = False
        '
        'Product_id
        '
        Me.Product_id.HeaderText = "Product_id"
        Me.Product_id.Name = "Product_id"
        Me.Product_id.ReadOnly = True
        Me.Product_id.Visible = False
        '
        'Catagory
        '
        Me.Catagory.HeaderText = "Product Catagory"
        Me.Catagory.Name = "Catagory"
        Me.Catagory.ReadOnly = True
        '
        'Product_Name
        '
        Me.Product_Name.HeaderText = "Product Name"
        Me.Product_Name.Name = "Product_Name"
        Me.Product_Name.ReadOnly = True
        '
        'Unit_Price
        '
        Me.Unit_Price.HeaderText = "Unit Price"
        Me.Unit_Price.Name = "Unit_Price"
        Me.Unit_Price.ReadOnly = True
        '
        'GST
        '
        Me.GST.HeaderText = "GST"
        Me.GST.Name = "GST"
        Me.GST.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Total_Price
        '
        Me.Total_Price.HeaderText = "Total Price"
        Me.Total_Price.Name = "Total_Price"
        Me.Total_Price.ReadOnly = True
        '
        'txt_Bill
        '
        Me.txt_Bill.Enabled = False
        Me.txt_Bill.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Bill.Location = New System.Drawing.Point(107, 351)
        Me.txt_Bill.Name = "txt_Bill"
        Me.txt_Bill.Size = New System.Drawing.Size(157, 29)
        Me.txt_Bill.TabIndex = 134
        Me.txt_Bill.Text = "0"
        '
        'lbl_Total_Bill
        '
        Me.lbl_Total_Bill.AutoSize = True
        Me.lbl_Total_Bill.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Total_Bill.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Total_Bill.Location = New System.Drawing.Point(717, 351)
        Me.lbl_Total_Bill.Name = "lbl_Total_Bill"
        Me.lbl_Total_Bill.Size = New System.Drawing.Size(95, 25)
        Me.lbl_Total_Bill.TabIndex = 145
        Me.lbl_Total_Bill.Text = "Total Bill"
        '
        'lbl_Discount
        '
        Me.lbl_Discount.AutoSize = True
        Me.lbl_Discount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Discount.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Discount.Location = New System.Drawing.Point(323, 351)
        Me.lbl_Discount.Name = "lbl_Discount"
        Me.lbl_Discount.Size = New System.Drawing.Size(96, 25)
        Me.lbl_Discount.TabIndex = 144
        Me.lbl_Discount.Text = "Discount"
        '
        'lbl_Bill
        '
        Me.lbl_Bill.AutoSize = True
        Me.lbl_Bill.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Bill.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Bill.Location = New System.Drawing.Point(41, 351)
        Me.lbl_Bill.Name = "lbl_Bill"
        Me.lbl_Bill.Size = New System.Drawing.Size(47, 25)
        Me.lbl_Bill.TabIndex = 143
        Me.lbl_Bill.Text = "Bill "
        '
        'cmb_Product_catagory
        '
        Me.cmb_Product_catagory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmb_Product_catagory.FormattingEnabled = True
        Me.cmb_Product_catagory.Items.AddRange(New Object() {"p", "k"})
        Me.cmb_Product_catagory.Location = New System.Drawing.Point(386, 35)
        Me.cmb_Product_catagory.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_Product_catagory.Name = "cmb_Product_catagory"
        Me.cmb_Product_catagory.Size = New System.Drawing.Size(156, 32)
        Me.cmb_Product_catagory.TabIndex = 128
        '
        'txt_Total_Price
        '
        Me.txt_Total_Price.Enabled = False
        Me.txt_Total_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Total_Price.Location = New System.Drawing.Point(700, 100)
        Me.txt_Total_Price.Name = "txt_Total_Price"
        Me.txt_Total_Price.Size = New System.Drawing.Size(159, 29)
        Me.txt_Total_Price.TabIndex = 132
        '
        'txt_Quantity
        '
        Me.txt_Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Quantity.Location = New System.Drawing.Point(157, 108)
        Me.txt_Quantity.Name = "txt_Quantity"
        Me.txt_Quantity.Size = New System.Drawing.Size(141, 29)
        Me.txt_Quantity.TabIndex = 131
        '
        'lbl_Total_Price
        '
        Me.lbl_Total_Price.AutoSize = True
        Me.lbl_Total_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Total_Price.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Total_Price.Location = New System.Drawing.Point(579, 104)
        Me.lbl_Total_Price.Name = "lbl_Total_Price"
        Me.lbl_Total_Price.Size = New System.Drawing.Size(115, 25)
        Me.lbl_Total_Price.TabIndex = 142
        Me.lbl_Total_Price.Text = "Total Price"
        '
        'lbl_Quantity
        '
        Me.lbl_Quantity.AutoSize = True
        Me.lbl_Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Quantity.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Quantity.Location = New System.Drawing.Point(10, 108)
        Me.lbl_Quantity.Name = "lbl_Quantity"
        Me.lbl_Quantity.Size = New System.Drawing.Size(92, 25)
        Me.lbl_Quantity.TabIndex = 141
        Me.lbl_Quantity.Text = "Quantity"
        '
        'lbl_Price
        '
        Me.lbl_Price.AutoSize = True
        Me.lbl_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Price.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Price.Location = New System.Drawing.Point(800, 36)
        Me.lbl_Price.Name = "lbl_Price"
        Me.lbl_Price.Size = New System.Drawing.Size(105, 25)
        Me.lbl_Price.TabIndex = 139
        Me.lbl_Price.Text = "Unit Price"
        '
        'lbl_GST
        '
        Me.lbl_GST.AutoSize = True
        Me.lbl_GST.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_GST.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_GST.Location = New System.Drawing.Point(345, 102)
        Me.lbl_GST.Name = "lbl_GST"
        Me.lbl_GST.Size = New System.Drawing.Size(74, 25)
        Me.lbl_GST.TabIndex = 138
        Me.lbl_GST.Text = "GST%"
        '
        'txt_GST
        '
        Me.txt_GST.Enabled = False
        Me.txt_GST.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_GST.Location = New System.Drawing.Point(434, 102)
        Me.txt_GST.Name = "txt_GST"
        Me.txt_GST.Size = New System.Drawing.Size(127, 29)
        Me.txt_GST.TabIndex = 130
        '
        'lbl_Product_Category
        '
        Me.lbl_Product_Category.AutoSize = True
        Me.lbl_Product_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Product_Category.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Product_Category.Location = New System.Drawing.Point(250, 39)
        Me.lbl_Product_Category.Name = "lbl_Product_Category"
        Me.lbl_Product_Category.Size = New System.Drawing.Size(119, 25)
        Me.lbl_Product_Category.TabIndex = 137
        Me.lbl_Product_Category.Text = "P Catagory"
        '
        'txt_Price
        '
        Me.txt_Price.Enabled = False
        Me.txt_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Price.Location = New System.Drawing.Point(925, 34)
        Me.txt_Price.Name = "txt_Price"
        Me.txt_Price.Size = New System.Drawing.Size(90, 29)
        Me.txt_Price.TabIndex = 129
        '
        'lbl_Customer_Id
        '
        Me.lbl_Customer_Id.AutoSize = True
        Me.lbl_Customer_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Customer_Id.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Customer_Id.Location = New System.Drawing.Point(45, 34)
        Me.lbl_Customer_Id.Name = "lbl_Customer_Id"
        Me.lbl_Customer_Id.Size = New System.Drawing.Size(130, 25)
        Me.lbl_Customer_Id.TabIndex = 130
        Me.lbl_Customer_Id.Text = "Customer ID"
        '
        'txt_Customer_Id
        '
        Me.txt_Customer_Id.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_Customer_Id.Enabled = False
        Me.txt_Customer_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Customer_Id.Location = New System.Drawing.Point(237, 31)
        Me.txt_Customer_Id.Name = "txt_Customer_Id"
        Me.txt_Customer_Id.Size = New System.Drawing.Size(189, 29)
        Me.txt_Customer_Id.TabIndex = 126
        '
        'lbl_Customer_Name
        '
        Me.lbl_Customer_Name.AutoSize = True
        Me.lbl_Customer_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Customer_Name.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Customer_Name.Location = New System.Drawing.Point(23, 94)
        Me.lbl_Customer_Name.Name = "lbl_Customer_Name"
        Me.lbl_Customer_Name.Size = New System.Drawing.Size(166, 25)
        Me.lbl_Customer_Name.TabIndex = 133
        Me.lbl_Customer_Name.Text = "Customer Name"
        '
        'txt_Customer_Name
        '
        Me.txt_Customer_Name.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_Customer_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Customer_Name.Location = New System.Drawing.Point(237, 84)
        Me.txt_Customer_Name.Name = "txt_Customer_Name"
        Me.txt_Customer_Name.Size = New System.Drawing.Size(189, 29)
        Me.txt_Customer_Name.TabIndex = 127
        '
        'Gpb_Customer_Detail
        '
        Me.Gpb_Customer_Detail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gpb_Customer_Detail.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Gpb_Customer_Detail.Controls.Add(Me.lbl_Customer_Id)
        Me.Gpb_Customer_Detail.Controls.Add(Me.txt_Customer_Id)
        Me.Gpb_Customer_Detail.Controls.Add(Me.lbl_Customer_Name)
        Me.Gpb_Customer_Detail.Controls.Add(Me.txt_Customer_Name)
        Me.Gpb_Customer_Detail.Controls.Add(Me.lbl_Mobile_No)
        Me.Gpb_Customer_Detail.Controls.Add(Me.lbl_Bill_Date)
        Me.Gpb_Customer_Detail.Controls.Add(Me.dtp_Bill_Date)
        Me.Gpb_Customer_Detail.Controls.Add(Me.txt_Mob_No)
        Me.Gpb_Customer_Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gpb_Customer_Detail.Location = New System.Drawing.Point(6, 72)
        Me.Gpb_Customer_Detail.Margin = New System.Windows.Forms.Padding(2)
        Me.Gpb_Customer_Detail.Name = "Gpb_Customer_Detail"
        Me.Gpb_Customer_Detail.Padding = New System.Windows.Forms.Padding(2)
        Me.Gpb_Customer_Detail.Size = New System.Drawing.Size(1053, 137)
        Me.Gpb_Customer_Detail.TabIndex = 18
        Me.Gpb_Customer_Detail.TabStop = False
        Me.Gpb_Customer_Detail.Text = "Customer Detail"
        '
        'lbl_Mobile_No
        '
        Me.lbl_Mobile_No.AutoSize = True
        Me.lbl_Mobile_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Mobile_No.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Mobile_No.Location = New System.Drawing.Point(532, 80)
        Me.lbl_Mobile_No.Name = "lbl_Mobile_No"
        Me.lbl_Mobile_No.Size = New System.Drawing.Size(115, 25)
        Me.lbl_Mobile_No.TabIndex = 132
        Me.lbl_Mobile_No.Text = "Mobile No."
        '
        'lbl_Bill_Date
        '
        Me.lbl_Bill_Date.AutoSize = True
        Me.lbl_Bill_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Bill_Date.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Bill_Date.Location = New System.Drawing.Point(517, 22)
        Me.lbl_Bill_Date.Name = "lbl_Bill_Date"
        Me.lbl_Bill_Date.Size = New System.Drawing.Size(92, 25)
        Me.lbl_Bill_Date.TabIndex = 131
        Me.lbl_Bill_Date.Text = "Bill Date"
        '
        'dtp_Bill_Date
        '
        Me.dtp_Bill_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.dtp_Bill_Date.Location = New System.Drawing.Point(713, 22)
        Me.dtp_Bill_Date.Name = "dtp_Bill_Date"
        Me.dtp_Bill_Date.Size = New System.Drawing.Size(219, 29)
        Me.dtp_Bill_Date.TabIndex = 128
        '
        'txt_Mob_No
        '
        Me.txt_Mob_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Mob_No.Location = New System.Drawing.Point(717, 82)
        Me.txt_Mob_No.MaxLength = 10
        Me.txt_Mob_No.Name = "txt_Mob_No"
        Me.txt_Mob_No.Size = New System.Drawing.Size(219, 29)
        Me.txt_Mob_No.TabIndex = 129
        '
        'btn_Refresh
        '
        Me.btn_Refresh.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Refresh.FlatAppearance.BorderSize = 0
        Me.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Refresh.ForeColor = System.Drawing.Color.White
        Me.btn_Refresh.Location = New System.Drawing.Point(180, 633)
        Me.btn_Refresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Refresh.Name = "btn_Refresh"
        Me.btn_Refresh.Size = New System.Drawing.Size(195, 45)
        Me.btn_Refresh.TabIndex = 20
        Me.btn_Refresh.Text = "Refresh"
        Me.btn_Refresh.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(617, 633)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 45)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Save.FlatAppearance.BorderSize = 0
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.ForeColor = System.Drawing.Color.White
        Me.btn_Save.Location = New System.Drawing.Point(399, 633)
        Me.btn_Save.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(195, 45)
        Me.btn_Save.TabIndex = 21
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'uc_Add_New_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Gpb_Purchase_Detail)
        Me.Controls.Add(Me.Gpb_Customer_Detail)
        Me.Controls.Add(Me.btn_Refresh)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_Add_New_Customer"
        Me.Size = New System.Drawing.Size(1061, 723)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Gpb_Purchase_Detail.ResumeLayout(False)
        Me.Gpb_Purchase_Detail.PerformLayout()
        CType(Me.dgv_Customer_Purchase_Details, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gpb_Customer_Detail.ResumeLayout(False)
        Me.Gpb_Customer_Detail.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents lbl_Per As System.Windows.Forms.Label
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents txt_Total_Bill As System.Windows.Forms.TextBox
    Friend WithEvents txt_Discount As System.Windows.Forms.TextBox
    Friend WithEvents Gpb_Purchase_Detail As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Product_Name As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Product_Name As System.Windows.Forms.Label
    Friend WithEvents dgv_Customer_Purchase_Details As System.Windows.Forms.DataGridView
    Friend WithEvents txt_Bill As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Total_Bill As System.Windows.Forms.Label
    Friend WithEvents lbl_Discount As System.Windows.Forms.Label
    Friend WithEvents lbl_Bill As System.Windows.Forms.Label
    Friend WithEvents cmb_Product_catagory As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Total_Price As System.Windows.Forms.TextBox
    Friend WithEvents txt_Quantity As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Total_Price As System.Windows.Forms.Label
    Friend WithEvents lbl_Quantity As System.Windows.Forms.Label
    Friend WithEvents lbl_Price As System.Windows.Forms.Label
    Friend WithEvents lbl_GST As System.Windows.Forms.Label
    Friend WithEvents txt_GST As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Product_Category As System.Windows.Forms.Label
    Friend WithEvents txt_Price As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Customer_Id As System.Windows.Forms.Label
    Friend WithEvents txt_Customer_Id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Customer_Name As System.Windows.Forms.Label
    Friend WithEvents txt_Customer_Name As System.Windows.Forms.TextBox
    Friend WithEvents Gpb_Customer_Detail As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Mobile_No As System.Windows.Forms.Label
    Friend WithEvents lbl_Bill_Date As System.Windows.Forms.Label
    Friend WithEvents dtp_Bill_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Mob_No As System.Windows.Forms.TextBox
    Friend WithEvents btn_Refresh As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents tb_Product_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cust_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Product_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Catagory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Product_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit_Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_Price As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
