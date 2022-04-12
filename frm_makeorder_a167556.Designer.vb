<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_makeorder_a167556
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_order_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_cust = New System.Windows.Forms.ComboBox()
        Me.cb_staff = New System.Windows.Forms.ComboBox()
        Me.lst_product = New System.Windows.Forms.ListBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Text_shipping = New System.Windows.Forms.TextBox()
        Me.Text_from = New System.Windows.Forms.TextBox()
        Me.Text_material = New System.Windows.Forms.TextBox()
        Me.Text_type = New System.Windows.Forms.TextBox()
        Me.Text_price = New System.Windows.Forms.TextBox()
        Me.Text_name = New System.Windows.Forms.TextBox()
        Me.Text_id = New System.Windows.Forms.TextBox()
        Me.btn_addtocart = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_invoiceid = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_date = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grd_cart = New System.Windows.Forms.DataGridView()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.tb_total = New System.Windows.Forms.TextBox()
        Me.btn_checkout = New System.Windows.Forms.Button()
        Me.nud_quantity = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_cart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Order ID:"
        '
        'tb_order_id
        '
        Me.tb_order_id.BackColor = System.Drawing.Color.White
        Me.tb_order_id.Location = New System.Drawing.Point(134, 20)
        Me.tb_order_id.Name = "tb_order_id"
        Me.tb_order_id.Size = New System.Drawing.Size(107, 22)
        Me.tb_order_id.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Staff ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Customer ID:"
        '
        'cb_cust
        '
        Me.cb_cust.FormattingEnabled = True
        Me.cb_cust.Location = New System.Drawing.Point(134, 51)
        Me.cb_cust.Name = "cb_cust"
        Me.cb_cust.Size = New System.Drawing.Size(107, 24)
        Me.cb_cust.Sorted = True
        Me.cb_cust.TabIndex = 21
        '
        'cb_staff
        '
        Me.cb_staff.FormattingEnabled = True
        Me.cb_staff.Location = New System.Drawing.Point(134, 83)
        Me.cb_staff.Name = "cb_staff"
        Me.cb_staff.Size = New System.Drawing.Size(107, 24)
        Me.cb_staff.Sorted = True
        Me.cb_staff.TabIndex = 22
        '
        'lst_product
        '
        Me.lst_product.FormattingEnabled = True
        Me.lst_product.ItemHeight = 16
        Me.lst_product.Location = New System.Drawing.Point(34, 131)
        Me.lst_product.Name = "lst_product"
        Me.lst_product.Size = New System.Drawing.Size(134, 260)
        Me.lst_product.TabIndex = 23
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(188, 130)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(216, 198)
        Me.pic_product.TabIndex = 36
        Me.pic_product.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(302, 520)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 17)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Shipping Fees:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(31, 520)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 17)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Product from:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(304, 465)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Material:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(31, 462)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(307, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Price:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(31, 408)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 17)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Name:"
        '
        'Text_shipping
        '
        Me.Text_shipping.BackColor = System.Drawing.Color.White
        Me.Text_shipping.Location = New System.Drawing.Point(304, 540)
        Me.Text_shipping.Name = "Text_shipping"
        Me.Text_shipping.Size = New System.Drawing.Size(107, 22)
        Me.Text_shipping.TabIndex = 42
        '
        'Text_from
        '
        Me.Text_from.BackColor = System.Drawing.Color.White
        Me.Text_from.Location = New System.Drawing.Point(34, 540)
        Me.Text_from.Name = "Text_from"
        Me.Text_from.Size = New System.Drawing.Size(249, 22)
        Me.Text_from.TabIndex = 41
        '
        'Text_material
        '
        Me.Text_material.BackColor = System.Drawing.Color.White
        Me.Text_material.Location = New System.Drawing.Point(304, 485)
        Me.Text_material.Name = "Text_material"
        Me.Text_material.Size = New System.Drawing.Size(107, 22)
        Me.Text_material.TabIndex = 40
        '
        'Text_type
        '
        Me.Text_type.BackColor = System.Drawing.Color.White
        Me.Text_type.Location = New System.Drawing.Point(34, 485)
        Me.Text_type.Name = "Text_type"
        Me.Text_type.Size = New System.Drawing.Size(249, 22)
        Me.Text_type.TabIndex = 39
        '
        'Text_price
        '
        Me.Text_price.BackColor = System.Drawing.Color.White
        Me.Text_price.Location = New System.Drawing.Point(304, 428)
        Me.Text_price.Name = "Text_price"
        Me.Text_price.Size = New System.Drawing.Size(107, 22)
        Me.Text_price.TabIndex = 38
        '
        'Text_name
        '
        Me.Text_name.BackColor = System.Drawing.Color.White
        Me.Text_name.Location = New System.Drawing.Point(34, 428)
        Me.Text_name.Name = "Text_name"
        Me.Text_name.Size = New System.Drawing.Size(249, 22)
        Me.Text_name.TabIndex = 37
        '
        'Text_id
        '
        Me.Text_id.BackColor = System.Drawing.Color.White
        Me.Text_id.Font = New System.Drawing.Font("Showcard Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_id.ForeColor = System.Drawing.Color.Black
        Me.Text_id.Location = New System.Drawing.Point(235, 345)
        Me.Text_id.Name = "Text_id"
        Me.Text_id.ReadOnly = True
        Me.Text_id.Size = New System.Drawing.Size(116, 30)
        Me.Text_id.TabIndex = 49
        Me.Text_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_addtocart
        '
        Me.btn_addtocart.Location = New System.Drawing.Point(218, 580)
        Me.btn_addtocart.Name = "btn_addtocart"
        Me.btn_addtocart.Size = New System.Drawing.Size(173, 35)
        Me.btn_addtocart.TabIndex = 50
        Me.btn_addtocart.Text = "ADD TO CART"
        Me.btn_addtocart.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("MV Boli", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(698, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 55)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Invoice"
        '
        'tb_invoiceid
        '
        Me.tb_invoiceid.BackColor = System.Drawing.Color.White
        Me.tb_invoiceid.Location = New System.Drawing.Point(638, 131)
        Me.tb_invoiceid.Name = "tb_invoiceid"
        Me.tb_invoiceid.ReadOnly = True
        Me.tb_invoiceid.Size = New System.Drawing.Size(115, 22)
        Me.tb_invoiceid.TabIndex = 52
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(548, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 17)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Invoice ID:"
        '
        'tb_date
        '
        Me.tb_date.BackColor = System.Drawing.Color.White
        Me.tb_date.Location = New System.Drawing.Point(846, 129)
        Me.tb_date.Name = "tb_date"
        Me.tb_date.ReadOnly = True
        Me.tb_date.Size = New System.Drawing.Size(145, 22)
        Me.tb_date.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(793, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 17)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Date:"
        '
        'grd_cart
        '
        Me.grd_cart.BackgroundColor = System.Drawing.Color.White
        Me.grd_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_cart.Location = New System.Drawing.Point(516, 171)
        Me.grd_cart.Name = "grd_cart"
        Me.grd_cart.RowTemplate.Height = 24
        Me.grd_cart.Size = New System.Drawing.Size(540, 336)
        Me.grd_cart.TabIndex = 56
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(786, 522)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(112, 24)
        Me.lbl_total.TabIndex = 57
        Me.lbl_total.Text = "TOTAL : RM"
        '
        'tb_total
        '
        Me.tb_total.BackColor = System.Drawing.Color.White
        Me.tb_total.Location = New System.Drawing.Point(904, 522)
        Me.tb_total.Name = "tb_total"
        Me.tb_total.ReadOnly = True
        Me.tb_total.Size = New System.Drawing.Size(140, 22)
        Me.tb_total.TabIndex = 58
        '
        'btn_checkout
        '
        Me.btn_checkout.Location = New System.Drawing.Point(732, 577)
        Me.btn_checkout.Name = "btn_checkout"
        Me.btn_checkout.Size = New System.Drawing.Size(108, 38)
        Me.btn_checkout.TabIndex = 59
        Me.btn_checkout.Text = "CHECKOUT"
        Me.btn_checkout.UseVisualStyleBackColor = True
        '
        'nud_quantity
        '
        Me.nud_quantity.Location = New System.Drawing.Point(34, 593)
        Me.nud_quantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_quantity.Name = "nud_quantity"
        Me.nud_quantity.Size = New System.Drawing.Size(113, 22)
        Me.nud_quantity.TabIndex = 60
        Me.nud_quantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        Me.Button2.Location = New System.Drawing.Point(1028, 559)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 38)
        Me.Button2.TabIndex = 68
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
        Me.Button1.Location = New System.Drawing.Point(1028, 603)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 38)
        Me.Button1.TabIndex = 69
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_makeorder_a167556
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_Dare2Fit_A167556.My.Resources.Resources.wave_textures_white_background_vector_53876_60286
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1081, 650)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.nud_quantity)
        Me.Controls.Add(Me.btn_checkout)
        Me.Controls.Add(Me.tb_total)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.grd_cart)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tb_date)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tb_invoiceid)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_addtocart)
        Me.Controls.Add(Me.Text_id)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Text_shipping)
        Me.Controls.Add(Me.Text_from)
        Me.Controls.Add(Me.Text_material)
        Me.Controls.Add(Me.Text_type)
        Me.Controls.Add(Me.Text_price)
        Me.Controls.Add(Me.Text_name)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lst_product)
        Me.Controls.Add(Me.cb_staff)
        Me.Controls.Add(Me.cb_cust)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_order_id)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frm_makeorder_a167556"
        Me.Text = "frm_makeorder_a167556"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_cart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents tb_order_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_cust As ComboBox
    Friend WithEvents cb_staff As ComboBox
    Friend WithEvents lst_product As ListBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Text_shipping As TextBox
    Friend WithEvents Text_from As TextBox
    Friend WithEvents Text_material As TextBox
    Friend WithEvents Text_type As TextBox
    Friend WithEvents Text_price As TextBox
    Friend WithEvents Text_name As TextBox
    Friend WithEvents Text_id As TextBox
    Friend WithEvents btn_addtocart As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents tb_invoiceid As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tb_date As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents grd_cart As DataGridView
    Friend WithEvents lbl_total As Label
    Friend WithEvents tb_total As TextBox
    Friend WithEvents btn_checkout As Button
    Friend WithEvents nud_quantity As NumericUpDown
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
