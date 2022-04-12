Public Class frm_products_a167556

    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Dim current_code As String

    Private Sub frm_products_a167556_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_list()
        clear_fields()

        PictureBox1.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Sub refresh_list()

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A167556"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        list_productID.DataSource = mydatatable
        list_productID.DisplayMember = "FLD_PRODUCT_ID"

    End Sub

    Private Sub refresh_text(matric As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A167556 WHERE FLD_PRODUCT_ID='" & matric & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        Text_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        Text_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        Text_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        Text_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        Text_material.Text = mydatatable.Rows(0).Item("FLD_MAIN_MATERIAL")
        Text_from.Text = mydatatable.Rows(0).Item("FLD_SHIP_FROM")
        Text_shipping.Text = mydatatable.Rows(0).Item("FLD_SHIPPING_FEES")

        Try
            PictureBox1.BackgroundImage = Image.FromFile("pictures/" & Text_id.Text & ".jpg")
        Catch ex As Exception
            PictureBox1.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try
    End Sub

    Private Sub clear_fields()

        Text_name.Text = ""
        Text_price.Text = ""
        Text_type.Text = ""
        Text_material.Text = ""
        Text_from.Text = ""
        Text_shipping.Text = ""
        PictureBox1.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        If Text_id.Text = "" Then
            Beep()
            MsgBox("Please select the item that you wish to update")
        End If

        If Text_id.Text IsNot "" Then
            run_sql_command("UPDATE TBL_PRODUCTS_A167556 SET FLD_PRODUCT_NAME='" & Text_name.Text & "' WHERE FLD_PRODUCT_ID='" & Text_id.Text & "'")
            run_sql_command("UPDATE TBL_PRODUCTS_A167556 SET FLD_PRICE=" & Text_price.Text & " WHERE FLD_PRODUCT_ID='" & Text_id.Text & "'")

            run_sql_command("UPDATE TBL_PRODUCTS_A167556 SET FLD_MAIN_MATERIAL='" & Text_material.Text & "' WHERE FLD_PRODUCT_ID='" & Text_id.Text & "'")
            run_sql_command("UPDATE TBL_PRODUCTS_A167556 SET FLD_SHIP_FROM='" & Text_from.Text & "' WHERE FLD_PRODUCT_ID='" & Text_id.Text & "'")
            run_sql_command("UPDATE TBL_PRODUCTS_A167556 SET FLD_SHIPPING_FEES='" & Text_shipping.Text & "' WHERE FLD_PRODUCT_ID='" & Text_id.Text & "'")

            Beep()
            'MsgBox("You have successfully updated the field")

            clear_fields()
        End If

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        If Text_id.Text = "" Then
            Beep()
            MsgBox("Please select the item that you wish to delete")
        End If

        If Text_id.Text IsNot "" Then
            Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & Text_id.Text & """?", MsgBoxStyle.YesNo)

            If delete_confirmation = MsgBoxResult.Yes Then

                run_sql_command("DELETE FROM TBL_PRODUCTS_A167556 WHERE FLD_PRODUCT_ID= '" & Text_id.Text & "'")

                clear_fields()

                PictureBox1.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")

                Beep()
                MsgBox("The item """ & Text_id.Text & """ has been successfully deleted.")

                refresh_list()
            End If
        End If


    End Sub

    Private Sub list_productID_MouseClick(sender As Object, e As MouseEventArgs) Handles list_productID.MouseClick
        refresh_text(list_productID.Text)
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
        frm_insertproduct_a167556.ShowDialog()
        refresh_list()

    End Sub

End Class