Public Class MainMenuFrm

    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        Dim frmCustomer As New CustomerListFrm
        frmCustomer.Show()
    End Sub

    Private Sub btnContract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContract.Click
        Dim frmContract As New ContractListFrm
        frmContract.Show()
    End Sub
End Class