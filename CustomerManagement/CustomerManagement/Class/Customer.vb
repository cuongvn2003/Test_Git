Public Class Customer

    Public Property Id As Integer
    Public Property FullName As String
    Public Property Address As String
    Public Property Phone As String
    Public Property Capital As Decimal
    Public Property EstablishedDate As DateTime

    Sub New(ByVal customerId As Integer, ByVal fullName As String, ByVal address As String, ByVal phone As String, ByVal capital As String, ByVal established As Date)
        ' TODO: Complete member initialization 
        Me.Id = customerId
        Me.FullName = fullName
        Me.Address = address
        Me.Phone = phone
        Me.Capital = capital
        Me.EstablishedDate = established
    End Sub
End Class
