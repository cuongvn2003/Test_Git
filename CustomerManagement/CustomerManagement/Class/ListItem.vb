Public Class ListItem
    Public Property Text As String
    Public Property Value As Integer

    Public Sub New(ByVal text As String, ByVal value As Integer)
        Me.Text = text
        Me.Value = value
    End Sub

    Public Overrides Function ToString() As String
        Return Text
    End Function
End Class
