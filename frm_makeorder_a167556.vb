Public Class frm_makeorder_a167556

    Dim Stotal As Double
    Dim current_row As Integer
    Dim SubTotalPrice2 As Double
    Dim TotalPrice2 As Double

    Dim Check_item As Boolean
    Dim lastitem2 As String

    Dim i As Integer = 0

    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"

    Private Sub frm_makeorder_a167556_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Stotal = 0.00

        pic_product.BackgroundImage = Image.FromFile(defaultpicture)

        Dim todaysdate As String = String.Format("{0:MM/dd/yyyy}", DateTime.Now)
        tb_date.Text = todaysdate

        Dim mysql2 As String = "SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMER_A167556"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
        myreader2.Fill(mydatatable2)
        cb_cust.DataSource = mydatatable2
        cb_cust.DisplayMember = "FLD_CUSTOMER_ID"

        Dim mysql3 As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF_A167556"
        Dim mydatatable3 As New DataTable
        Dim myreader3 As New OleDb.OleDbDataAdapter(mysql3, myconnection)
        myreader3.Fill(mydatatable3)
        cb_staff.DataSource = mydatatable3
        cb_staff.DisplayMember = "FLD_STAFF_ID"

        refresh_list()

        grd_cart.ColumnCount = 6

        grd_cart.Columns(0).HeaderText = "INVOICE ID"
        grd_cart.Columns(1).HeaderText = "ITEM ID"
        grd_cart.Columns(2).HeaderText = "ITEM NAME"
        grd_cart.Columns(3).HeaderText = "ORDER QUANTITY"
        grd_cart.Columns(4).HeaderText = "ITEM PRICE"
        grd_cart.Columns(5).HeaderText = "SUB-TOTALS"

        tb_order_id.Text = generate_orderID()
        tb_invoiceid.Text = generate_invoiceID()
    End Sub

    Private Function generate_orderID() As String
        Dim mysql4 As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A167556"
        Dim mydatatable4 As New DataTable
        Dim myreader4 As New OleDb.OleDbDataAdapter(mysql4, myconnection)
        myreader4.Fill(mydatatable4)

        If mydatatable4.Rows.Count = 0 Then
            Return "O" & 1
        End If

        If mydatatable4.Rows.Count > 0 Then
            Dim lastid As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTID FROM TBL_ORDER_A167556").Rows(0).Item("LASTID")

            Dim newid As String = "O" & Mid(lastid, 2) + 1
            Return newid
        End If

    End Function

    Private Function generate_invoiceID() As String
        Dim mysql5 As String = "SELECT FLD_INVOICE_ID FROM TBL_INVOICE_A167556"
        Dim mydatatable5 As New DataTable
        Dim myreader5 As New OleDb.OleDbDataAdapter(mysql5, myconnection)
        myreader5.Fill(mydatatable5)

        If mydatatable5.Rows.Count = 0 Then
            Return "I" & 1
        End If

        If mydatatable5.Rows.Count > 0 Then
            Dim lastid As String = run_sql_query("SELECT MAX(FLD_INVOICE_ID) AS LASTID FROM TBL_INVOICE_A167556").Rows(0).Item("LASTID")

            Dim newid As String = "I" & Mid(lastid, 2) + 1
            Return newid
        End If
    End Function

    Private Sub refresh_list()
        Dim mysql As String = "SELECT FLD_PRODUCT_NAME FROM TBL_PRODUCTS_A167556"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lst_product.DataSource = mydatatable
        lst_product.DisplayMember = "FLD_PRODUCT_NAME"
    End Sub

    Private Sub refresh_text(name As String)
        Try
            Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A167556 WHERE FLD_PRODUCT_NAME='" & name & "'"
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
                pic_product.BackgroundImage = Image.FromFile("pictures/" & Text_id.Text & ".jpg")
            Catch ex As Exception
                pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
            End Try
        Catch
            MsgBox("Error" & vbCrLf)
        End Try
    End Sub

    Private Sub clear_fields()

        Text_id.Text = ""
        Text_name.Text = ""
        Text_price.Text = ""
        Text_type.Text = ""
        Text_material.Text = ""
        Text_from.Text = ""

        Text_shipping.Text = ""
        pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        nud_quantity.Text = 1

    End Sub

    Private Sub lst_product_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_product.MouseClick
        refresh_text(lst_product.Text)
    End Sub

    Private Sub btn_addtocart_Click(sender As Object, e As EventArgs) Handles btn_addtocart.Click
        Dim newrow = grd_cart.RowCount - 1
        Dim quantity As Double
        Dim price As Double
        quantity = Val(nud_quantity.Text)
        price = Val(Text_price.Text)
        If (IsNumeric(nud_quantity.Text)) Then

            SubTotalPrice2 = price * quantity
            TotalPrice2 = TotalPrice2 + SubTotalPrice2

            tb_total.Text = TotalPrice2

            If Text_id.Text.Equals("") Then
                Beep()
                MsgBox("No item selected!")
            Else
                grd_cart.Rows.Insert(newrow, New String() {tb_invoiceid.Text, Text_id.Text, Text_name.Text, nud_quantity.Text, Text_price.Text, SubTotalPrice2})
            End If

            Dim increment As String = tb_invoiceid.Text
            Dim newinvoice As String = "I" & Mid(increment, 2) + 1

            tb_invoiceid.Text = newinvoice

            clear_fields()
        Else
            MsgBox("Opps! Please ensure your input is correct")
        End If
    End Sub

    Private Sub btn_checkout_Click(sender As Object, e As EventArgs) Handles btn_checkout.Click

        If grd_cart.Rows.Count > 0 Then
            Dim mytransaction As OleDb.OleDbTransaction

            myconnection2.Open()
            mytransaction = myconnection2.BeginTransaction

            Try
                Dim mysql As String = "INSERT INTO TBL_ORDER_A167556 VALUES ('" & tb_order_id.Text & "', '" & cb_cust.Text & "', '" & cb_staff.Text & "'," & tb_total.Text & ")"
                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)
                mywriter.ExecuteNonQuery()
                For x As Integer = 0 To grd_cart.RowCount - 2

                    Dim invoice_id As String = grd_cart(0, x).Value
                    Dim prod_id As String = grd_cart(1, x).Value
                    Dim order_id As String = tb_order_id.Text
                    Dim item_name As String = grd_cart(2, x).Value
                    Dim item_quantity As Integer = grd_cart(3, x).Value
                    Dim item_price As String = grd_cart(4, x).Value
                    Dim subtotal As Integer = grd_cart(5, x).Value

                    Dim mysql2 As String = "INSERT INTO TBL_INVOICE_A167556 VALUES ('" & invoice_id & "', '" & order_id & "','" & prod_id & "', '" & tb_date.Text & "'," & item_quantity & ", " & subtotal & ")"
                    Dim mywriter2 As New OleDb.OleDbCommand(mysql2, myconnection2, mytransaction)
                    mywriter2.ExecuteNonQuery()


                Next
                MsgBox("Transaction Successful!")

                mytransaction.Commit()
                myconnection2.Close()

                Dim a As Integer = grd_cart.RowCount - 2
                Beep()

                grd_cart.Rows.Clear()
                tb_order_id.Text = generate_orderID()
                'tb_invoiceid.Text = generate_invoiceID()
                tb_total.Text = ""
                clear_fields()
                TotalPrice2 = 0
                SubTotalPrice2 = 0
            Catch ex As Exception

                mytransaction.Rollback()
                Beep()
                MsgBox("An error occured while confirming order: " & vbCrLf & vbCrLf & ex.Message)
                myconnection2.Close()

                'grd_cart.Rows.Clear()
                'clear_fields()

            End Try
            i = 0
        Else
            MsgBox("Please add product")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frm_order_a167556.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class