Public Class frm_vieworder_a167556
    Private Sub frm_vieworder_a167556_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim todaysdate As String = String.Format("{0:MM/dd/yyyy}", DateTime.Now)
        tb_date.Text = todaysdate

        refresh_list()
    End Sub

    Private Sub refresh_list()
        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A167556"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lst_orderid.DataSource = mydatatable
        lst_orderid.DisplayMember = "FLD_ORDER_ID"
    End Sub

    Private Sub refresh_text(name As String)
        Try
            Dim mysql As String = "SELECT * FROM TBL_ORDER_A167556 WHERE FLD_ORDER_ID='" & name & "'"
            Dim mydatatable As New DataTable
            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
            myreader.Fill(mydatatable)
            tb_staff.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
            tb_cust.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_ID")
            tb_orderid.Text = mydatatable.Rows(0).Item("FLD_ORDER_ID")
            tb_total.Text = mydatatable.Rows(0).Item("FLD_TOTAL")

        Catch
            MsgBox("Error" & vbCrLf)
        End Try
    End Sub

    Private Sub lst_orderid_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_orderid.MouseClick
        refresh_text(lst_orderid.Text)
        get_order_code()
    End Sub

    Private Sub get_order_code()
        Try

            Dim current_row As String = lst_orderid.Text

            grd_invoice.DataSource = run_sql_query("SELECT * FROM TBL_INVOICE_A167556 where FLD_ORDER_ID ='" & current_row & "'")

            grd_invoice.Columns(0).HeaderText = "INVOICE ID"
            grd_invoice.Columns(1).HeaderText = "PRODUCT ID"
            grd_invoice.Columns(2).HeaderText = "ORDER ID"
            grd_invoice.Columns(3).HeaderText = "DATE"
            grd_invoice.Columns(4).HeaderText = "QUANTITY"
            grd_invoice.Columns(4).HeaderText = "SUBTOTAL"

        Catch ex As Exception
            Beep()
            MsgBox(“There Is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frm_order_a167556.ShowDialog()
        refresh_list()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class