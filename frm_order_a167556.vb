Public Class frm_order_a167556
    Private Sub frm_order_a167556_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_ORDER_A167556"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)
        'DataGridView1.DataSource = mydatatable
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_mainmenu_a167556.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button_order_Click(sender As Object, e As EventArgs) Handles Button_order.Click
        Me.Hide()
        frm_makeorder_a167556.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        frm_vieworder_a167556.Show()
    End Sub
End Class