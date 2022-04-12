Public Class frm_insertcustomer_a167556

    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"

    Private Sub frm_insertstaff_a167556_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Text_id.Text = generate_matric()

        txt_picture.Text = defaultpicture
        PictureBox1.BackgroundImage = Image.FromFile(defaultpicture)
    End Sub

    Private Sub clear_fields()

        Text_id.Text = generate_matric()
        Text_name.Text = ""
        Text_phone.Text = ""
        Text_email.Text = ""
        PictureBox1.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A167556 VALUES ('” & Text_id.Text & "', '" & Text_name.Text & "', '" & Text_phone.Text & "', '" & Text_email.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & Text_id.Text & ".jpg")
            txt_picture.Text = defaultpicture
            PictureBox1.BackgroundImage = Image.FromFile(defaultpicture)

            Beep()
            MsgBox("Your staff has been successfully inserted")
            clear_fields()

        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try

    End Sub

    Private Function generate_matric() As String

        Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_CUSTOMER_ID) AS LASTMATRIC FROM TBL_CUSTOMER_A167556").Rows(0).Item("LASTMATRIC")
        Dim newmatric As String = "C" & Mid(lastmatric, 2) + 1
        Return newmatric

    End Function

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        PictureBox1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_picture.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub btn__Click(sender As Object, e As EventArgs) Handles btn_.Click

        frm_customer_a167556.Show()
        Me.Hide()

    End Sub
End Class