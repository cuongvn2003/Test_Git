Imports MySql.Data.MySqlClient

Public Class CustomerEditFrm

    Private customerId As String = String.Empty

    Public Sub New(ByVal cusomer_id As String)

        InitializeComponent()

        customerId = cusomer_id
    End Sub


    Private Sub CustomerEditForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If String.IsNullOrEmpty(customerId) Then
            RefreshForm()
            btnDelete.Enabled = False

            dateEstablished.Format = DateTimePickerFormat.Custom
            dateEstablished.CustomFormat = " "
        Else
            btnDelete.Enabled = True

            Using connection As MySqlConnection = DatabaseHelper.GetConnection()
                connection.Open()

                Dim query As String = "SELECT * FROM Customers WHERE Id = @CustomerId"

                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@CustomerId", customerId)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()

                            ' Mapping data customer detail
                            txtFullName.Text = Convert.ToString(reader("FullName"))
                            txtAddress.Text = Convert.ToString(reader("Address"))
                            txtPhone.Text = Convert.ToString(reader("Phone"))
                            txtCapital.Text = Convert.ToString(reader("Capital"))
                            dateEstablished.Value = Convert.ToDateTime(reader("EstablishedDate"))

                        End While
                    End Using
                End Using

                DatabaseHelper.CloseConnection(connection)
            End Using

        End If

    End Sub

    Private Sub RefreshForm()
        txtFullName.Refresh()
        txtAddress.Refresh()
        txtPhone.Refresh()
        txtCapital.Refresh()
        dateEstablished.Refresh()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Using connection As MySqlConnection = DatabaseHelper.GetConnection()
                connection.Open()

                Dim query As String = String.Empty
                If String.IsNullOrEmpty(customerId) Then
                    ' Set the query insert customer
                    query = "INSERT INTO Customers (FullName, Address, Phone, Capital, EstablishedDate) VALUES (@FullName, @Address, @Phone, @Capital, @EstablishedDate)"
                Else
                    ' Set the query update customer
                    query = "UPDATE Customers SET FullName = @FullName, Address = @Address, Phone = @Phone, Capital = @Capital, EstablishedDate = @EstablishedDate WHERE Id = @CustomerId"
                End If

                ' Create a MySqlCommand object and set the parameters
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@FullName", txtFullName.Text)
                command.Parameters.AddWithValue("@Address", txtAddress.Text)
                command.Parameters.AddWithValue("@Phone", txtPhone.Text)
                command.Parameters.AddWithValue("@Capital", txtCapital.Text)
                command.Parameters.AddWithValue("@EstablishedDate", dateEstablished.Value)

                If String.IsNullOrEmpty(customerId) = False Then
                    command.Parameters.AddWithValue("@CustomerId", customerId)
                End If

                ' Execute insert/update customer 
                command.ExecuteNonQuery()

                DatabaseHelper.CloseConnection(connection)

                MessageBox.Show("Saved Successfully")
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while processing your request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If (DialogResult.Yes = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) Then
            Using connection As MySqlConnection = DatabaseHelper.GetConnection()
                connection.Open()

                Dim query As String = "DELETE FROM Customers WHERE Id = @CustomerId"

                ' Create a MySqlCommand object and set the parameters
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@CustomerId", customerId)

                ' Execute delete customer
                command.ExecuteNonQuery()

                DatabaseHelper.CloseConnection(connection)
            End Using
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dateEstablished_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateEstablished.ValueChanged
        dateEstablished.Format = DateTimePickerFormat.Custom
        dateEstablished.CustomFormat = "yyyy/MM/dd"
    End Sub
End Class