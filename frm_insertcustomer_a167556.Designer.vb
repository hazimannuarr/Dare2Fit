<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertcustomer_a167556
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
        Me.btn_ = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Text_email = New System.Windows.Forms.TextBox()
        Me.Text_phone = New System.Windows.Forms.TextBox()
        Me.Text_name = New System.Windows.Forms.TextBox()
        Me.Text_id = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_
        '
        Me.btn_.BackColor = System.Drawing.Color.Transparent
        Me.btn_.BackgroundImage = Global.prj_Dare2Fit_A167556.My.Resources.Resources.back
        Me.btn_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_.Location = New System.Drawing.Point(751, 405)
        Me.btn_.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_.Name = "btn_"
        Me.btn_.Size = New System.Drawing.Size(37, 34)
        Me.btn_.TabIndex = 66
        Me.btn_.UseVisualStyleBackColor = False
        '
        'btn_insert
        '
        Me.btn_insert.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(640, 213)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(78, 35)
        Me.btn_insert.TabIndex = 65
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_picture
        '
        Me.btn_picture.Location = New System.Drawing.Point(108, 371)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(121, 31)
        Me.btn_picture.TabIndex = 64
        Me.btn_picture.Text = "Select Picture"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(120, 343)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(100, 22)
        Me.txt_picture.TabIndex = 63
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(68, 114)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 208)
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'Text_email
        '
        Me.Text_email.Location = New System.Drawing.Point(333, 294)
        Me.Text_email.Name = "Text_email"
        Me.Text_email.Size = New System.Drawing.Size(242, 22)
        Me.Text_email.TabIndex = 61
        '
        'Text_phone
        '
        Me.Text_phone.Location = New System.Drawing.Point(333, 241)
        Me.Text_phone.Name = "Text_phone"
        Me.Text_phone.Size = New System.Drawing.Size(242, 22)
        Me.Text_phone.TabIndex = 60
        '
        'Text_name
        '
        Me.Text_name.Location = New System.Drawing.Point(333, 191)
        Me.Text_name.Name = "Text_name"
        Me.Text_name.Size = New System.Drawing.Size(242, 22)
        Me.Text_name.TabIndex = 59
        '
        'Text_id
        '
        Me.Text_id.Location = New System.Drawing.Point(333, 141)
        Me.Text_id.Name = "Text_id"
        Me.Text_id.Size = New System.Drawing.Size(242, 22)
        Me.Text_id.TabIndex = 58
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 60)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Insert Customer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(340, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(340, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Phone Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(340, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Customer ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(340, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Email:"
        '
        'frm_insertcustomer_a167556
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_Dare2Fit_A167556.My.Resources.Resources.wave_textures_white_background_vector_53876_60286
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Text_email)
        Me.Controls.Add(Me.Text_phone)
        Me.Controls.Add(Me.Text_name)
        Me.Controls.Add(Me.Text_id)
        Me.Name = "frm_insertcustomer_a167556"
        Me.Text = "frm_insertcustomer_a167556"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_picture As Button
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Text_email As TextBox
    Friend WithEvents Text_phone As TextBox
    Friend WithEvents Text_name As TextBox
    Friend WithEvents Text_id As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
