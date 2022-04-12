<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vieworder_a167556
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
        Me.lst_orderid = New System.Windows.Forms.ListBox()
        Me.tb_staff = New System.Windows.Forms.TextBox()
        Me.tb_cust = New System.Windows.Forms.TextBox()
        Me.grd_invoice = New System.Windows.Forms.DataGridView()
        Me.tb_total = New System.Windows.Forms.TextBox()
        Me.tb_orderid = New System.Windows.Forms.TextBox()
        Me.tb_date = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.grd_invoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lst_orderid
        '
        Me.lst_orderid.FormattingEnabled = True
        Me.lst_orderid.ItemHeight = 16
        Me.lst_orderid.Location = New System.Drawing.Point(52, 72)
        Me.lst_orderid.Name = "lst_orderid"
        Me.lst_orderid.Size = New System.Drawing.Size(98, 308)
        Me.lst_orderid.TabIndex = 54
        '
        'tb_staff
        '
        Me.tb_staff.Location = New System.Drawing.Point(429, 52)
        Me.tb_staff.Name = "tb_staff"
        Me.tb_staff.Size = New System.Drawing.Size(100, 22)
        Me.tb_staff.TabIndex = 56
        '
        'tb_cust
        '
        Me.tb_cust.Location = New System.Drawing.Point(260, 104)
        Me.tb_cust.Name = "tb_cust"
        Me.tb_cust.Size = New System.Drawing.Size(100, 22)
        Me.tb_cust.TabIndex = 57
        '
        'grd_invoice
        '
        Me.grd_invoice.BackgroundColor = System.Drawing.Color.White
        Me.grd_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_invoice.Location = New System.Drawing.Point(211, 146)
        Me.grd_invoice.Name = "grd_invoice"
        Me.grd_invoice.RowTemplate.Height = 24
        Me.grd_invoice.Size = New System.Drawing.Size(393, 257)
        Me.grd_invoice.TabIndex = 58
        '
        'tb_total
        '
        Me.tb_total.BackColor = System.Drawing.Color.White
        Me.tb_total.Location = New System.Drawing.Point(633, 265)
        Me.tb_total.Name = "tb_total"
        Me.tb_total.ReadOnly = True
        Me.tb_total.Size = New System.Drawing.Size(141, 22)
        Me.tb_total.TabIndex = 59
        '
        'tb_orderid
        '
        Me.tb_orderid.BackColor = System.Drawing.Color.White
        Me.tb_orderid.Location = New System.Drawing.Point(258, 52)
        Me.tb_orderid.Name = "tb_orderid"
        Me.tb_orderid.ReadOnly = True
        Me.tb_orderid.Size = New System.Drawing.Size(100, 22)
        Me.tb_orderid.TabIndex = 60
        '
        'tb_date
        '
        Me.tb_date.BackColor = System.Drawing.Color.White
        Me.tb_date.Location = New System.Drawing.Point(429, 104)
        Me.tb_date.Name = "tb_date"
        Me.tb_date.ReadOnly = True
        Me.tb_date.Size = New System.Drawing.Size(100, 22)
        Me.tb_date.TabIndex = 61
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(629, 238)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(112, 24)
        Me.lbl_total.TabIndex = 62
        Me.lbl_total.Text = "TOTAL : RM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(255, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Order ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(257, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Customer ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(426, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Staff ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(426, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Date:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.prj_Dare2Fit_A167556.My.Resources.Resources.back
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(746, 355)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 38)
        Me.Button2.TabIndex = 67
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.prj_Dare2Fit_A167556.My.Resources.Resources.close_icon_png_19
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(746, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 38)
        Me.Button1.TabIndex = 68
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_vieworder_a167556
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_Dare2Fit_A167556.My.Resources.Resources.wave_textures_white_background_vector_53876_60286
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.tb_date)
        Me.Controls.Add(Me.tb_orderid)
        Me.Controls.Add(Me.tb_total)
        Me.Controls.Add(Me.grd_invoice)
        Me.Controls.Add(Me.tb_cust)
        Me.Controls.Add(Me.tb_staff)
        Me.Controls.Add(Me.lst_orderid)
        Me.Name = "frm_vieworder_a167556"
        Me.Text = "frm_vieworder_a167556"
        CType(Me.grd_invoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lst_orderid As ListBox
    Friend WithEvents tb_staff As TextBox
    Friend WithEvents tb_cust As TextBox
    Friend WithEvents grd_invoice As DataGridView
    Friend WithEvents tb_total As TextBox
    Friend WithEvents tb_orderid As TextBox
    Friend WithEvents tb_date As TextBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
