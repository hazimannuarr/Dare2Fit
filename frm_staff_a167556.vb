Public Class frm_staff_a167556

    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Dim current_code As String

    Private Sub frm_staff_a167556_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_list()
        clear_fields()

        PictureBox1.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Sub refresh_list()

        Dim mysql As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF_A167556"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        list_staffID.DataSource = mydatatable
        list_staffID.DisplayMember = "FLD_STAFF_ID"

    End Sub

    Private Sub refresh_text(matric As String)
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A167556 WHERE FLD_STAFF_ID='" & matric & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        Text_id.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
        Text_name.Text = mydatatable.Rows(0).Item("FLD_STAFF_NAME")
        Text_phone.Text = mydatatable.Rows(0).Item("FLD_STAFF_PHONE")
        Text_email.Text = mydatatable.Rows(0).Item("FLD_STAFF_EMAIL")

        Try
            PictureBox1.BackgroundImage = Image.FromFile("pictures/" & Text_id.Text & ".jpg")
        Catch ex As Exception
            PictureBox1.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try
    End Sub

    Private Sub clear_fields()

        Text_name.Text = ""
        Text_phone.Text = ""
        Text_email.Text = ""
        PictureBox1.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")

    End Sub

    Private Sub list_staffID_MouseClick(sender As Object, e As MouseEventArgs) Handles list_staffID.MouseClick
        refresh_text(list_staffID.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_mainmenu_a167556.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        Me.Hide()
        Beep()
        frm_insertstaff_a167556.ShowDialog()
        refresh_list()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If Text_id.Text = "" Then
            Beep()
            MsgBox("Please select the item that you wish to update")
        End If

        If Text_id.Text IsNot "" Then
            run_sql_command("UPDATE TBL_STAFF_A167556 SET FLD_STAFF_NAME='" & Text_name.Text & "' WHERE FLD_STAFF_ID='" & Text_id.Text & "'")
            run_sql_command("UPDATE TBL_STAFF_A167556 SET FLD_STAFF_PHONE='" & Text_phone.Text & "' WHERE FLD_STAFF_ID='" & Text_id.Text & "'")
            run_sql_command("UPDATE TBL_STAFF_A167556 SET FLD_STAFF_EMAIL='" & Text_email.Text & "' WHERE FLD_STAFF_ID='" & Text_id.Text & "'")

            Beep()
            MsgBox("You have successfully updated the field")

            clear_fields()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If Text_id.Text = "" Then
            Beep()
            MsgBox("Please select the staff that you wish to delete")
        End If

        If Text_id.Text IsNot "" Then
            Dim delete_confirmation = MsgBox("Are you sure you would like to delete the staff """ & Text_id.Text & """?", MsgBoxStyle.YesNo)

            If delete_confirmation = MsgBoxResult.Yes Then

                run_sql_command("DELETE FROM TBL_STAFF_A167556 WHERE FLD_STAFF_ID= '" & Text_id.Text & "'")

                clear_fields()

                PictureBox1.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")

                Beep()
                MsgBox("The staff """ & Text_id.Text & """ has been successfully deleted.")

                refresh_list()
            End If
        End If
    End Sub
End Class