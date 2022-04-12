<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_products_a167556
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
        Me.list_productID = New System.Windows.Forms.ListBox()
        Me.Text_name = New System.Windows.Forms.TextBox()
        Me.Text_price = New System.Windows.Forms.TextBox()
        Me.Text_type = New System.Windows.Forms.TextBox()
        Me.Text_material = New System.Windows.Forms.TextBox()
        Me.Text_from = New System.Windows.Forms.TextBox()
        Me.Text_shipping = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.Text_id = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'list_productID
        '
        Me.list_productID.BackColor = System.Drawing.Color.White
        Me.list_productID.FormattingEnabled = True
        Me.list_productID.ItemHeight = 16
        Me.list_productID.Location = New System.Drawing.Point(29, 70)
        Me.list_productID.Name = "list_productID"
        Me.list_productID.Size = New System.Drawing.Size(100, 292)
        Me.list_productID.TabIndex = 0
        '
        'Text_name
        '
        Me.Text_name.BackColor = System.Drawing.Color.White
        Me.Text_name.Location = New System.Drawing.Point(404, 155)
        Me.Text_name.Name = "Text_name"
        Me.Text_name.Size = New System.Drawing.Size(249, 22)
        Me.Text_name.TabIndex = 1
        '
        'Text_price
        '
        Me.Text_price.BackColor = System.Drawing.Color.White
        Me.Text_price.Location = New System.Drawing.Point(674, 155)
        Me.Text_price.Name = "Text_price"
        Me.Text_price.Size = New System.Drawing.Size(107, 22)
        Me.Text_price.TabIndex = 2
        '
        'Text_type
        '
        Me.Text_type.BackColor = System.Drawing.Color.White
        Me.Text_type.Location = New System.Drawing.Point(404, 212)
        Me.Text_type.Name = "Text_type"
        Me.Text_type.Size = New System.Drawing.Size(249, 22)
        Me.Text_type.TabIndex = 3
        '
        'Text_material
        '
        Me.Text_material.BackColor = System.Drawing.Color.White
        Me.Text_material.Location = New System.Drawing.Point(674, 212)
        Me.Text_material.Name = "Text_material"
        Me.Text_material.Size = New System.Drawing.Size(107, 22)
        Me.Text_material.TabIndex = 4
        '
        'Text_from
        '
        Me.Text_from.BackColor = System.Drawing.Color.White
        Me.Text_from.Location = New System.Drawing.Point(404, 267)
        Me.Text_from.Name = "Text_from"
        Me.Text_from.Size = New System.Drawing.Size(249, 22)
        Me.Text_from.TabIndex = 5
        '
        'Text_shipping
        '
        Me.Text_shipping.BackColor = System.Drawing.Color.White
        Me.Text_shipping.Location = New System.Drawing.Point(674, 267)
        Me.Text_shipping.Name = "Text_shipping"
        Me.Text_shipping.Size = New System.Drawing.Size(107, 22)
        Me.Text_shipping.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(164, 122)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 199)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(401, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(677, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(401, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(674, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Material:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(401, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Product from:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(672, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Shipping Fees:"
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
        Me.Button1.TabIndex = 22
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.Button2.Location = New System.Drawing.Point(746, 356)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 38)
        Me.Button2.TabIndex = 23
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_new
        '
        Me.btn_new.Font = New System.Drawing.Font("Microsoft Tai Le", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.Location = New System.Drawing.Point(12, 415)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(139, 23)
        Me.btn_new.TabIndex = 26
        Me.btn_new.Text = "ADD NEW PRODUCT"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(508, 307)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(72, 23)
        Me.btn_update.TabIndex = 27
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(598, 307)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 28
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'Text_id
        '
        Me.Text_id.BackColor = System.Drawing.Color.White
        Me.Text_id.Font = New System.Drawing.Font("Showcard Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_id.ForeColor = System.Drawing.Color.Black
        Me.Text_id.Location = New System.Drawing.Point(140, 22)
        Me.Text_id.Name = "Text_id"
        Me.Text_id.ReadOnly = True
        Me.Text_id.Size = New System.Drawing.Size(557, 30)
        Me.Text_id.TabIndex = 29
        Me.Text_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_products_a167556
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_Dare2Fit_A167556.My.Resources.Resources.wave_textures_white_background_vector_53876_60286
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Text_id)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Text_shipping)
        Me.Controls.Add(Me.Text_from)
        Me.Controls.Add(Me.Text_material)
        Me.Controls.Add(Me.Text_type)
        Me.Controls.Add(Me.Text_price)
        Me.Controls.Add(Me.Text_name)
        Me.Controls.Add(Me.list_productID)
        Me.Name = "frm_products_a167556"
        Me.Text = "Products"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents list_productID As ListBox
    Friend WithEvents Text_name As TextBox
    Friend WithEvents Text_price As TextBox
    Friend WithEvents Text_type As TextBox
    Friend WithEvents Text_material As TextBox
    Friend WithEvents Text_from As TextBox
    Friend WithEvents Text_shipping As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents Text_id As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
