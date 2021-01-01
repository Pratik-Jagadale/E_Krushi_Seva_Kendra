<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_View_Customer
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
        Me.txt_Product_Id = New System.Windows.Forms.TextBox()
        Me.cmb_Search_Distributor = New System.Windows.Forms.ComboBox()
        Me.lbl_Search_Product_By = New System.Windows.Forms.Label()
        Me.Cust_View = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.Cust_View, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 2
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
        Me.Label1.Location = New System.Drawing.Point(414, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "View Customer Details"
        '
        'btn_Search
        '
        Me.btn_Search.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Search.FlatAppearance.BorderSize = 0
        Me.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.Color.White
        Me.btn_Search.Location = New System.Drawing.Point(767, 82)
        Me.btn_Search.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(143, 41)
        Me.btn_Search.TabIndex = 116
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'txt_Product_Id
        '
        Me.txt_Product_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Product_Id.Location = New System.Drawing.Point(501, 87)
        Me.txt_Product_Id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Product_Id.Name = "txt_Product_Id"
        Me.txt_Product_Id.Size = New System.Drawing.Size(247, 29)
        Me.txt_Product_Id.TabIndex = 115
        '
        'cmb_Search_Distributor
        '
        Me.cmb_Search_Distributor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Search_Distributor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmb_Search_Distributor.FormattingEnabled = True
        Me.cmb_Search_Distributor.Items.AddRange(New Object() {"Customer_ID", "Customer_Name"})
        Me.cmb_Search_Distributor.Location = New System.Drawing.Point(249, 87)
        Me.cmb_Search_Distributor.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_Search_Distributor.Name = "cmb_Search_Distributor"
        Me.cmb_Search_Distributor.Size = New System.Drawing.Size(206, 32)
        Me.cmb_Search_Distributor.TabIndex = 114
        '
        'lbl_Search_Product_By
        '
        Me.lbl_Search_Product_By.AutoSize = True
        Me.lbl_Search_Product_By.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Search_Product_By.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Search_Product_By.Location = New System.Drawing.Point(28, 94)
        Me.lbl_Search_Product_By.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Search_Product_By.Name = "lbl_Search_Product_By"
        Me.lbl_Search_Product_By.Size = New System.Drawing.Size(209, 25)
        Me.lbl_Search_Product_By.TabIndex = 117
        Me.lbl_Search_Product_By.Text = "Search Customer By"
        '
        'Cust_View
        '
        Me.Cust_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Cust_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cust_View.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Cust_View.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cust_View.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Cust_View.Location = New System.Drawing.Point(0, 164)
        Me.Cust_View.Name = "Cust_View"
        Me.Cust_View.Size = New System.Drawing.Size(1061, 559)
        Me.Cust_View.TabIndex = 118
        '
        'uc_View_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Cust_View)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.txt_Product_Id)
        Me.Controls.Add(Me.cmb_Search_Distributor)
        Me.Controls.Add(Me.lbl_Search_Product_By)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_View_Customer"
        Me.Size = New System.Drawing.Size(1061, 723)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Cust_View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents txt_Product_Id As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Search_Distributor As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Search_Product_By As System.Windows.Forms.Label
    Friend WithEvents Cust_View As System.Windows.Forms.DataGridView

End Class
