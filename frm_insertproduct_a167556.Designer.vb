<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproduct_a167556
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Text_id = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Text_shipping = New System.Windows.Forms.TextBox()
        Me.Text_from = New System.Windows.Forms.TextBox()
        Me.Text_material = New System.Windows.Forms.TextBox()
        Me.Text_type = New System.Windows.Forms.TextBox()
        Me.Text_price = New System.Windows.Forms.TextBox()
        Me.Text_name = New System.Windows.Forms.TextBox()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_ = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(482, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 18)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Product ID:"
        '
        'Text_id
        '
        Me.Text_id.BackColor = System.Drawing.Color.White
        Me.Text_id.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_id.Location = New System.Drawing.Point(439, 141)
        Me.Text_id.Name = "Text_id"
        Me.Text_id.ReadOnly = True
        Me.Text_id.Size = New System.Drawing.Size(156, 24)
        Me.Text_id.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(605, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 17)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Shipping Fees:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(325, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 17)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Product from:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(607, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Material:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(325, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(610, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Price:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(325, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Name:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(53, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 223)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Text_shipping
        '
        Me.Text_shipping.BackColor = System.Drawing.Color.White
        Me.Text_shipping.Location = New System.Drawing.Point(607, 308)
        Me.Text_shipping.Name = "Text_shipping"
        Me.Text_shipping.Size = New System.Drawing.Size(107, 22)
        Me.Text_shipping.TabIndex = 36
        '
        'Text_from
        '
        Me.Text_from.BackColor = System.Drawing.Color.White
        Me.Text_from.Location = New System.Drawing.Point(328, 308)
        Me.Text_from.Name = "Text_from"
        Me.Text_from.Size = New System.Drawing.Size(249, 22)
        Me.Text_from.TabIndex = 35
        '
        'Text_material
        '
        Me.Text_material.BackColor = System.Drawing.Color.White
        Me.Text_material.Location = New System.Drawing.Point(607, 252)
        Me.Text_material.Name = "Text_material"
        Me.Text_material.Size = New System.Drawing.Size(107, 22)
        Me.Text_material.TabIndex = 34
        '
        'Text_type
        '
        Me.Text_type.BackColor = System.Drawing.Color.White
        Me.Text_type.Location = New System.Drawing.Point(328, 252)
        Me.Text_type.Name = "Text_type"
        Me.Text_type.Size = New System.Drawing.Size(249, 22)
        Me.Text_type.TabIndex = 33
        '
        'Text_price
        '
        Me.Text_price.BackColor = System.Drawing.Color.White
        Me.Text_price.Location = New System.Drawing.Point(607, 194)
        Me.Text_price.Name = "Text_price"
        Me.Text_price.Size = New System.Drawing.Size(107, 22)
        Me.Text_price.TabIndex = 32
        '
        'Text_name
        '
        Me.Text_name.BackColor = System.Drawing.Color.White
        Me.Text_name.Location = New System.Drawing.Point(328, 194)
        Me.Text_name.Name = "Text_name"
        Me.Text_name.Size = New System.Drawing.Size(249, 22)
        Me.Text_name.TabIndex = 31
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(114, 341)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(100, 22)
        Me.txt_picture.TabIndex = 52
        '
        'btn_picture
        '
        Me.btn_picture.Location = New System.Drawing.Point(105, 369)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(121, 40)
        Me.btn_picture.TabIndex = 53
        Me.btn_picture.Text = "Select Picture"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(497, 354)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(89, 23)
        Me.btn_insert.TabIndex = 54
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_
        '
        Me.btn_.BackColor = System.Drawing.Color.Transparent
        Me.btn_.BackgroundImage = Global.prj_Dare2Fit_A167556.My.Resources.Resources.back
        Me.btn_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_.Location = New System.Drawing.Point(750, 409)
        Me.btn_.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_.Name = "btn_"
        Me.btn_.Size = New System.Drawing.Size(38, 34)
        Me.btn_.TabIndex = 55
        Me.btn_.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Script", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(275, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(290, 60)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Add Product"
        '
        'frm_insertproduct_a167556
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_Dare2Fit_A167556.My.Resources.Resources.wave_textures_white_background_vector_53876_60286
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Text_shipping)
        Me.Controls.Add(Me.Text_from)
        Me.Controls.Add(Me.Text_material)
        Me.Controls.Add(Me.Text_type)
        Me.Controls.Add(Me.Text_price)
        Me.Controls.Add(Me.Text_name)
        Me.Controls.Add(Me.Text_id)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frm_insertproduct_a167556"
        Me.Text = "frm_insertproduct_a167556"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Text_id As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Text_shipping As TextBox
    Friend WithEvents Text_from As TextBox
    Friend WithEvents Text_material As TextBox
    Friend WithEvents Text_type As TextBox
    Friend WithEvents Text_price As TextBox
    Friend WithEvents Text_name As TextBox
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents btn_picture As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_ As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label2 As Label
End Class
