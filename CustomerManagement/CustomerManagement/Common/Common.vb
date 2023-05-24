Public Class Common

    ''' <summary>
    ''' Get the list of contract statuses
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetContractStatusList() As List(Of ListItem)
        ' Create a list of ListItem objects
        Dim statusList As New List(Of ListItem)()

        statusList.Add(New ListItem("-- Choose --", "-1"))
        statusList.Add(New ListItem("Before Acceptance", "0"))
        statusList.Add(New ListItem("Acceptance Testing", "1"))
        statusList.Add(New ListItem("Contract Termination", "2"))
        statusList.Add(New ListItem("Contract Cancellation", "3"))
        statusList.Add(New ListItem("Installment Payment", "4"))

        Return statusList
    End Function

    ''' <summary>
    ''' Get the list of contract type
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetContractTypeList() As List(Of ListItem)
        Dim typesList As New List(Of ListItem)()

        typesList.Add(New ListItem("-- Choose --", "-1"))
        typesList.Add(New ListItem("General", "0"))
        typesList.Add(New ListItem("Car", "1"))
        typesList.Add(New ListItem("Soft", "2"))
        Return typesList
    End Function

End Class
