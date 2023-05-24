Public Class Contract

    Public Property Id As Integer
    Public Property ContractNumber As String
    Public Property BranchNumber As String
    Public Property IsRenewable As String
    Public Property ContractType As String
    Public Property ContractDate As String
    Public Property Status As String

    Sub New(ByVal contractId As Integer, ByVal contractNumber As String, ByVal branchNumber As String, ByVal isRenewable As String, ByVal contractType As String, ByVal contractDate As Date, ByVal status As String)
        ' TODO: Complete contract initialization 
        Me.Id = contractId
        Me.ContractNumber = contractNumber
        Me.BranchNumber = branchNumber
        Me.IsRenewable = isRenewable
        Me.ContractType = contractType
        Me.ContractDate = contractDate
        Me.Status = status
    End Sub

End Class
