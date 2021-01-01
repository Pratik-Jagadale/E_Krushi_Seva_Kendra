<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_View_stock
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
        Me.dgv_Stock_Detail = New System.Windows.Forms.DataGridView()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.txt_Product_Id = New System.Windows.Forms.TextBox()
        Me.cmb_Search_Distributor = New System.Windows.Forms.ComboBox()
        Me.lbl_Search__Stock_Update_By = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_Stock_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 1
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
        Me.Label1.Location = New System.Drawing.Point(424, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "View Stock"
        '
        'dgv_Stock_Detail
        '
        Me.dgv_Stock_Detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Stock_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Stock_Detail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_Stock_Detail.Location = New System.Drawing.Point(0, 217)
        Me.dgv_Stock_Detail.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_Stock_Detail.Name = "dgv_Stock_Detail"
        Me.dgv_Stock_Detail.RowTemplate.Height = 24
        Me.dgv_Stock_Detail.Size = New System.Drawing.Size(1061, 506)
        Me.dgv_Stock_Detail.TabIndex = 113
        '
        'btn_Search
        '
        Me.btn_Search.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Search.FlatAppearance.BorderSize = 0
        Me.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.Color.White
        Me.btn_Search.Location = New System.Drawing.Point(860, 88)
        Me.btn_Search.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(133, 42)
        Me.btn_Search.TabIndex = 111
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'txt_Product_Id
        '
        Me.txt_Product_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txt_Product_Id.Location = New System.Drawing.Point(553, 98)
        Me.txt_Product_Id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Product_Id.Name = "txt_Product_Id"
        Me.txt_Product_Id.Size = New System.Drawing.Size(272, 29)
        Me.txt_Product_Id.TabIndex = 110
        '
        'cmb_Search_Distributor
        '
        Me.cmb_Search_Distributor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmb_Search_Distributor.FormattingEnabled = True
        Me.cmb_Search_Distributor.Items.AddRange(New Object() {"Product ID", "Product Name"})
        Me.cmb_Search_Distributor.Location = New System.Drawing.Point(313, 98)
        Me.cmb_Search_Distributor.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_Search_Distributor.Name = "cmb_Search_Distributor"
        Me.cmb_Search_Distributor.Size = New System.Drawing.Size(214, 32)
        Me.cmb_Search_Distributor.TabIndex = 109
        '
        'lbl_Search__Stock_Update_By
        '
        Me.lbl_Search__Stock_Update_By.AutoSize = True
        Me.lbl_Search__Stock_Update_By.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lbl_Search__Stock_Update_By.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_Search__Stock_Update_By.Location = New System.Drawing.Point(18, 105)
        Me.lbl_Search__Stock_Update_By.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Search__Stock_Update_By.Name = "lbl_Search__Stock_Update_By"
        Me.lbl_Search__Stock_Update_By.Size = New System.Drawing.Size(246, 25)
        Me.lbl_Search__Stock_Update_By.TabIndex = 112
        Me.lbl_Search__Stock_Update_By.Text = "Search Stock Update By"
        '
        'uc_View_stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgv_Stock_Detail)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.txt_Product_Id)
        Me.Controls.Add(Me.cmb_Search_Distributor)
        Me.Controls.Add(Me.lbl_Search__Stock_Update_By)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_View_stock"
        Me.Size = New System.Drawing.Size(1061, 723)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_Stock_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_Stock_Detail As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents txt_Product_Id As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Search_Distributor As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Search__Stock_Update_By As System.Windows.Forms.Label

End Class
