<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.btn_Report = New System.Windows.Forms.Button()
        Me.btn_Jonral_info = New System.Windows.Forms.Button()
        Me.Pnl_User_Management = New System.Windows.Forms.Panel()
        Me.btn_Delete_Password = New System.Windows.Forms.Button()
        Me.btn_Change_Password = New System.Windows.Forms.Button()
        Me.btn_Add_New_User = New System.Windows.Forms.Button()
        Me.btn_User_Management = New System.Windows.Forms.Button()
        Me.Pnl_Stock_Master = New System.Windows.Forms.Panel()
        Me.btn_View_Stock = New System.Windows.Forms.Button()
        Me.btn_Add_New_Stock = New System.Windows.Forms.Button()
        Me.btn_Stock = New System.Windows.Forms.Button()
        Me.Pnl_Product_Matser = New System.Windows.Forms.Panel()
        Me.btn_View_Product = New System.Windows.Forms.Button()
        Me.btn_Update_Product = New System.Windows.Forms.Button()
        Me.btn_Add_New_Product = New System.Windows.Forms.Button()
        Me.btn_Product_Master = New System.Windows.Forms.Button()
        Me.Pnl_Customer_Master = New System.Windows.Forms.Panel()
        Me.btn_View_Customer = New System.Windows.Forms.Button()
        Me.btn_Add_New_Customer = New System.Windows.Forms.Button()
        Me.btn_Customer_Master = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.panel_Main_Menu = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Pnl_User_Management.SuspendLayout()
        Me.Pnl_Stock_Master.SuspendLayout()
        Me.Pnl_Product_Matser.SuspendLayout()
        Me.Pnl_Customer_Master.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panel_Main_Menu.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.btn_Report)
        Me.Panel1.Controls.Add(Me.btn_Jonral_info)
        Me.Panel1.Controls.Add(Me.Pnl_User_Management)
        Me.Panel1.Controls.Add(Me.btn_User_Management)
        Me.Panel1.Controls.Add(Me.Pnl_Stock_Master)
        Me.Panel1.Controls.Add(Me.btn_Stock)
        Me.Panel1.Controls.Add(Me.Pnl_Product_Matser)
        Me.Panel1.Controls.Add(Me.btn_Product_Master)
        Me.Panel1.Controls.Add(Me.Pnl_Customer_Master)
        Me.Panel1.Controls.Add(Me.btn_Customer_Master)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 768)
        Me.Panel1.TabIndex = 7
        '
        'btn_Report
        '
        Me.btn_Report.BackColor = System.Drawing.Color.Green
        Me.btn_Report.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Report.FlatAppearance.BorderSize = 0
        Me.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Report.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Report.Location = New System.Drawing.Point(0, 652)
        Me.btn_Report.Name = "btn_Report"
        Me.btn_Report.Size = New System.Drawing.Size(304, 45)
        Me.btn_Report.TabIndex = 10
        Me.btn_Report.Text = "Reports"
        Me.btn_Report.UseVisualStyleBackColor = False
        '
        'btn_Jonral_info
        '
        Me.btn_Jonral_info.BackColor = System.Drawing.Color.Green
        Me.btn_Jonral_info.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Jonral_info.FlatAppearance.BorderSize = 0
        Me.btn_Jonral_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Jonral_info.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Jonral_info.Location = New System.Drawing.Point(0, 607)
        Me.btn_Jonral_info.Name = "btn_Jonral_info"
        Me.btn_Jonral_info.Size = New System.Drawing.Size(304, 45)
        Me.btn_Jonral_info.TabIndex = 9
        Me.btn_Jonral_info.Text = "About Fetrilizers"
        Me.btn_Jonral_info.UseVisualStyleBackColor = False
        '
        'Pnl_User_Management
        '
        Me.Pnl_User_Management.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Pnl_User_Management.Controls.Add(Me.btn_Delete_Password)
        Me.Pnl_User_Management.Controls.Add(Me.btn_Change_Password)
        Me.Pnl_User_Management.Controls.Add(Me.btn_Add_New_User)
        Me.Pnl_User_Management.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_User_Management.Location = New System.Drawing.Point(0, 521)
        Me.Pnl_User_Management.Name = "Pnl_User_Management"
        Me.Pnl_User_Management.Size = New System.Drawing.Size(304, 86)
        Me.Pnl_User_Management.TabIndex = 8
        Me.Pnl_User_Management.Visible = False
        '
        'btn_Delete_Password
        '
        Me.btn_Delete_Password.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Delete_Password.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Delete_Password.FlatAppearance.BorderSize = 0
        Me.btn_Delete_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Delete_Password.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete_Password.Location = New System.Drawing.Point(0, 50)
        Me.btn_Delete_Password.Name = "btn_Delete_Password"
        Me.btn_Delete_Password.Size = New System.Drawing.Size(304, 25)
        Me.btn_Delete_Password.TabIndex = 2
        Me.btn_Delete_Password.Text = "Delete Password"
        Me.btn_Delete_Password.UseVisualStyleBackColor = False
        '
        'btn_Change_Password
        '
        Me.btn_Change_Password.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Change_Password.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Change_Password.FlatAppearance.BorderSize = 0
        Me.btn_Change_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Change_Password.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Change_Password.Location = New System.Drawing.Point(0, 25)
        Me.btn_Change_Password.Name = "btn_Change_Password"
        Me.btn_Change_Password.Size = New System.Drawing.Size(304, 25)
        Me.btn_Change_Password.TabIndex = 1
        Me.btn_Change_Password.Text = "Change Password"
        Me.btn_Change_Password.UseVisualStyleBackColor = False
        '
        'btn_Add_New_User
        '
        Me.btn_Add_New_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Add_New_User.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Add_New_User.FlatAppearance.BorderSize = 0
        Me.btn_Add_New_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add_New_User.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add_New_User.Location = New System.Drawing.Point(0, 0)
        Me.btn_Add_New_User.Name = "btn_Add_New_User"
        Me.btn_Add_New_User.Size = New System.Drawing.Size(304, 25)
        Me.btn_Add_New_User.TabIndex = 0
        Me.btn_Add_New_User.Text = "Add New User"
        Me.btn_Add_New_User.UseVisualStyleBackColor = False
        '
        'btn_User_Management
        '
        Me.btn_User_Management.BackColor = System.Drawing.Color.Green
        Me.btn_User_Management.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_User_Management.FlatAppearance.BorderSize = 0
        Me.btn_User_Management.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_User_Management.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_User_Management.Location = New System.Drawing.Point(0, 476)
        Me.btn_User_Management.Name = "btn_User_Management"
        Me.btn_User_Management.Size = New System.Drawing.Size(304, 45)
        Me.btn_User_Management.TabIndex = 7
        Me.btn_User_Management.Text = "User Management"
        Me.btn_User_Management.UseVisualStyleBackColor = False
        '
        'Pnl_Stock_Master
        '
        Me.Pnl_Stock_Master.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Pnl_Stock_Master.Controls.Add(Me.btn_View_Stock)
        Me.Pnl_Stock_Master.Controls.Add(Me.btn_Add_New_Stock)
        Me.Pnl_Stock_Master.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Stock_Master.Location = New System.Drawing.Point(0, 412)
        Me.Pnl_Stock_Master.Name = "Pnl_Stock_Master"
        Me.Pnl_Stock_Master.Size = New System.Drawing.Size(304, 64)
        Me.Pnl_Stock_Master.TabIndex = 6
        Me.Pnl_Stock_Master.Visible = False
        '
        'btn_View_Stock
        '
        Me.btn_View_Stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_View_Stock.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_View_Stock.FlatAppearance.BorderSize = 0
        Me.btn_View_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_View_Stock.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_View_Stock.Location = New System.Drawing.Point(0, 25)
        Me.btn_View_Stock.Name = "btn_View_Stock"
        Me.btn_View_Stock.Size = New System.Drawing.Size(304, 25)
        Me.btn_View_Stock.TabIndex = 2
        Me.btn_View_Stock.Text = "View Stock Details"
        Me.btn_View_Stock.UseVisualStyleBackColor = False
        '
        'btn_Add_New_Stock
        '
        Me.btn_Add_New_Stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Add_New_Stock.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Add_New_Stock.FlatAppearance.BorderSize = 0
        Me.btn_Add_New_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add_New_Stock.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add_New_Stock.Location = New System.Drawing.Point(0, 0)
        Me.btn_Add_New_Stock.Name = "btn_Add_New_Stock"
        Me.btn_Add_New_Stock.Size = New System.Drawing.Size(304, 25)
        Me.btn_Add_New_Stock.TabIndex = 0
        Me.btn_Add_New_Stock.Text = "Add New Stock"
        Me.btn_Add_New_Stock.UseVisualStyleBackColor = False
        '
        'btn_Stock
        '
        Me.btn_Stock.BackColor = System.Drawing.Color.Green
        Me.btn_Stock.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Stock.FlatAppearance.BorderSize = 0
        Me.btn_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Stock.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Stock.Location = New System.Drawing.Point(0, 367)
        Me.btn_Stock.Name = "btn_Stock"
        Me.btn_Stock.Size = New System.Drawing.Size(304, 45)
        Me.btn_Stock.TabIndex = 5
        Me.btn_Stock.Text = "Stock"
        Me.btn_Stock.UseVisualStyleBackColor = False
        '
        'Pnl_Product_Matser
        '
        Me.Pnl_Product_Matser.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Pnl_Product_Matser.Controls.Add(Me.btn_View_Product)
        Me.Pnl_Product_Matser.Controls.Add(Me.btn_Update_Product)
        Me.Pnl_Product_Matser.Controls.Add(Me.btn_Add_New_Product)
        Me.Pnl_Product_Matser.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Product_Matser.Location = New System.Drawing.Point(0, 274)
        Me.Pnl_Product_Matser.Name = "Pnl_Product_Matser"
        Me.Pnl_Product_Matser.Size = New System.Drawing.Size(304, 93)
        Me.Pnl_Product_Matser.TabIndex = 4
        Me.Pnl_Product_Matser.Visible = False
        '
        'btn_View_Product
        '
        Me.btn_View_Product.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_View_Product.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_View_Product.FlatAppearance.BorderSize = 0
        Me.btn_View_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_View_Product.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_View_Product.Location = New System.Drawing.Point(0, 50)
        Me.btn_View_Product.Name = "btn_View_Product"
        Me.btn_View_Product.Size = New System.Drawing.Size(304, 25)
        Me.btn_View_Product.TabIndex = 2
        Me.btn_View_Product.Text = "View Ferlizer Details"
        Me.btn_View_Product.UseVisualStyleBackColor = False
        '
        'btn_Update_Product
        '
        Me.btn_Update_Product.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Update_Product.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Update_Product.FlatAppearance.BorderSize = 0
        Me.btn_Update_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Update_Product.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update_Product.Location = New System.Drawing.Point(0, 25)
        Me.btn_Update_Product.Name = "btn_Update_Product"
        Me.btn_Update_Product.Size = New System.Drawing.Size(304, 25)
        Me.btn_Update_Product.TabIndex = 1
        Me.btn_Update_Product.Text = "Update fetlizer"
        Me.btn_Update_Product.UseVisualStyleBackColor = False
        '
        'btn_Add_New_Product
        '
        Me.btn_Add_New_Product.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Add_New_Product.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Add_New_Product.FlatAppearance.BorderSize = 0
        Me.btn_Add_New_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add_New_Product.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add_New_Product.Location = New System.Drawing.Point(0, 0)
        Me.btn_Add_New_Product.Name = "btn_Add_New_Product"
        Me.btn_Add_New_Product.Size = New System.Drawing.Size(304, 25)
        Me.btn_Add_New_Product.TabIndex = 0
        Me.btn_Add_New_Product.Text = "Add New Fertilizer"
        Me.btn_Add_New_Product.UseVisualStyleBackColor = False
        '
        'btn_Product_Master
        '
        Me.btn_Product_Master.BackColor = System.Drawing.Color.Green
        Me.btn_Product_Master.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Product_Master.FlatAppearance.BorderSize = 0
        Me.btn_Product_Master.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Product_Master.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Product_Master.Location = New System.Drawing.Point(0, 229)
        Me.btn_Product_Master.Name = "btn_Product_Master"
        Me.btn_Product_Master.Size = New System.Drawing.Size(304, 45)
        Me.btn_Product_Master.TabIndex = 3
        Me.btn_Product_Master.Text = "Fertilizer Master"
        Me.btn_Product_Master.UseVisualStyleBackColor = False
        '
        'Pnl_Customer_Master
        '
        Me.Pnl_Customer_Master.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Pnl_Customer_Master.Controls.Add(Me.btn_View_Customer)
        Me.Pnl_Customer_Master.Controls.Add(Me.btn_Add_New_Customer)
        Me.Pnl_Customer_Master.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Customer_Master.Location = New System.Drawing.Point(0, 161)
        Me.Pnl_Customer_Master.Name = "Pnl_Customer_Master"
        Me.Pnl_Customer_Master.Size = New System.Drawing.Size(304, 68)
        Me.Pnl_Customer_Master.TabIndex = 2
        Me.Pnl_Customer_Master.Visible = False
        '
        'btn_View_Customer
        '
        Me.btn_View_Customer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_View_Customer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_View_Customer.FlatAppearance.BorderSize = 0
        Me.btn_View_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_View_Customer.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_View_Customer.Location = New System.Drawing.Point(0, 25)
        Me.btn_View_Customer.Name = "btn_View_Customer"
        Me.btn_View_Customer.Size = New System.Drawing.Size(304, 25)
        Me.btn_View_Customer.TabIndex = 2
        Me.btn_View_Customer.Text = "View Customer Details"
        Me.btn_View_Customer.UseVisualStyleBackColor = False
        '
        'btn_Add_New_Customer
        '
        Me.btn_Add_New_Customer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Add_New_Customer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Add_New_Customer.FlatAppearance.BorderSize = 0
        Me.btn_Add_New_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add_New_Customer.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add_New_Customer.Location = New System.Drawing.Point(0, 0)
        Me.btn_Add_New_Customer.Name = "btn_Add_New_Customer"
        Me.btn_Add_New_Customer.Size = New System.Drawing.Size(304, 25)
        Me.btn_Add_New_Customer.TabIndex = 0
        Me.btn_Add_New_Customer.Text = "Add New Customer"
        Me.btn_Add_New_Customer.UseVisualStyleBackColor = False
        '
        'btn_Customer_Master
        '
        Me.btn_Customer_Master.BackColor = System.Drawing.Color.Green
        Me.btn_Customer_Master.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Customer_Master.FlatAppearance.BorderSize = 0
        Me.btn_Customer_Master.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Customer_Master.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Customer_Master.Location = New System.Drawing.Point(0, 116)
        Me.btn_Customer_Master.Name = "btn_Customer_Master"
        Me.btn_Customer_Master.Size = New System.Drawing.Size(304, 45)
        Me.btn_Customer_Master.TabIndex = 1
        Me.btn_Customer_Master.Text = "Customer Master"
        Me.btn_Customer_Master.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(304, 116)
        Me.Panel2.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(304, 116)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RectangleShape1.BorderWidth = 5
        Me.RectangleShape1.CornerRadius = 15
        Me.RectangleShape1.Location = New System.Drawing.Point(35, 16)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(196, 73)
        '
        'panel_Main_Menu
        '
        Me.panel_Main_Menu.Controls.Add(Me.PictureBox2)
        Me.panel_Main_Menu.Location = New System.Drawing.Point(305, 45)
        Me.panel_Main_Menu.Name = "panel_Main_Menu"
        Me.panel_Main_Menu.Size = New System.Drawing.Size(1061, 723)
        Me.panel_Main_Menu.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Location = New System.Drawing.Point(305, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1061, 45)
        Me.Panel3.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "E   Krushi Seva Kendra"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.E_krushi_Seva_Kendra.My.Resources.Resources.delete_icon
        Me.Button1.Location = New System.Drawing.Point(997, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.E_krushi_Seva_Kendra.My.Resources.Resources.gettyimages_923212310_2048x2048
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1061, 723)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 54)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "  E    "
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panel_Main_Menu)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "Main_Menu"
        Me.Text = "Main_Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Pnl_User_Management.ResumeLayout(False)
        Me.Pnl_Stock_Master.ResumeLayout(False)
        Me.Pnl_Product_Matser.ResumeLayout(False)
        Me.Pnl_Customer_Master.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panel_Main_Menu.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Pnl_User_Management As System.Windows.Forms.Panel
    Friend WithEvents btn_Delete_Password As System.Windows.Forms.Button
    Friend WithEvents btn_Change_Password As System.Windows.Forms.Button
    Friend WithEvents btn_Add_New_User As System.Windows.Forms.Button
    Friend WithEvents btn_User_Management As System.Windows.Forms.Button
    Friend WithEvents Pnl_Stock_Master As System.Windows.Forms.Panel
    Friend WithEvents btn_View_Stock As System.Windows.Forms.Button
    Friend WithEvents btn_Add_New_Stock As System.Windows.Forms.Button
    Friend WithEvents btn_Stock As System.Windows.Forms.Button
    Friend WithEvents Pnl_Product_Matser As System.Windows.Forms.Panel
    Friend WithEvents btn_View_Product As System.Windows.Forms.Button
    Friend WithEvents btn_Update_Product As System.Windows.Forms.Button
    Friend WithEvents btn_Add_New_Product As System.Windows.Forms.Button
    Friend WithEvents btn_Product_Master As System.Windows.Forms.Button
    Friend WithEvents Pnl_Customer_Master As System.Windows.Forms.Panel
    Friend WithEvents btn_View_Customer As System.Windows.Forms.Button
    Friend WithEvents btn_Add_New_Customer As System.Windows.Forms.Button
    Friend WithEvents btn_Customer_Master As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents panel_Main_Menu As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_Report As System.Windows.Forms.Button
    Friend WithEvents btn_Jonral_info As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
