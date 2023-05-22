Imports MySql.Data.MySqlClient

Public Class CustomerManagementForm

    Private connectionString As String = "Server=127.0.0.1;Database=lease_package;Uid=root;Pwd=123456;"
    Private dtCustomer As New DataTable

    Public Function GetConnection() As MySqlConnection
        Dim connection As New MySqlConnection(connectionString)
        Return connection
    End Function

    Public Sub CloseConnection(ByVal connection As MySqlConnection)
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub LoadCustomerList()
        Try
            ' Refresh data customer
            dtCustomer.Clear()
            Dim index As Integer = 0
            Using connection As MySqlConnection = GetConnection()
                connection.Open()

                Dim query As String = "SELECT * FROM Customers"

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()

                            index = index + 1
                            ' Mapping data customer detail
                            Dim customerId As Integer = Convert.ToInt32(reader("Id"))
                            Dim fullName As String = Convert.ToString(reader("FullName"))
                            Dim address As String = Convert.ToString(reader("Address"))
                            Dim phone As String = Convert.ToString(reader("Phone"))
                            Dim capital As String = Convert.ToString(reader("Capital"))
                            Dim established As DateTime = Convert.ToDateTime(reader("EstablishedDate")).ToString("yyyy/MM/dd")

                            ' Add columns filled in the customer DataTable.
                            dtCustomer.Rows.Add(customerId, index, fullName, address, phone, capital, established)

                        End While
                    End Using
                End Using

                CloseConnection(connection)
            End Using

            If (dtCustomer.Rows.Count > 0) Then
                dgvCustomer.DataSource = dtCustomer
            Else
                dgvCustomer.DataSource = Nothing
            End If


        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the customer list: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    Private Sub CreateCustomerDataTable()
        ' Create 6 typed columns in the DataTable.
        dtCustomer.Columns.Add("Id", GetType(Integer))
        dtCustomer.Columns.Add("No", GetType(Integer))
        dtCustomer.Columns.Add("FullName", GetType(String))
        dtCustomer.Columns.Add("Address", GetType(String))
        dtCustomer.Columns.Add("Phone", GetType(String))
        dtCustomer.Columns.Add("Capital", GetType(String))
        dtCustomer.Columns.Add("EstablishedDate", GetType(String))
    End Sub

    Private Sub CustomerManagementForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Create new DataTable instance
        CreateCustomerDataTable()

        txtFullName.Focus()

        LoadCustomerList()

        dgvCustomer.ClearSelection()

    End Sub

    Private Sub CustomerManagementForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Using connection As MySqlConnection = GetConnection()
                connection.Open()

                ' Set the query insert customer
                Dim query As String = "INSERT INTO Customers (FullName, Address, Phone, Capital, EstablishedDate) VALUES (@FullName, @Address, @Phone, @Capital, @EstablishedDate)"

                ' Create a MySqlCommand object and set the parameters
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@FullName", txtFullName.Text)
                command.Parameters.AddWithValue("@Address", txtAddress.Text)
                command.Parameters.AddWithValue("@Phone", txtPhone.Text)
                command.Parameters.AddWithValue("@Capital", txtCapital.Text)
                command.Parameters.AddWithValue("@EstablishedDate", dateEstablished.Value)

                ' Execute insert customer 
                command.ExecuteNonQuery()

                CloseConnection(connection)

                MessageBox.Show("Saved Successfully")
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while processing your request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            LoadCustomerList()
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If (String.IsNullOrEmpty(txtCustomerId.Text.Trim)) Then
                MessageBox.Show("Please select the row you want to update")
                Return
            End If

            Dim customerId As Integer = Convert.ToInt32(txtCustomerId.Text)

            Using connection As MySqlConnection = GetConnection()
                connection.Open()

                ' Set the query update customer
                Dim query As String = "UPDATE Customers SET FullName = @FullName, Address = @Address, Phone = @Phone, Capital = @Capital, EstablishedDate = @EstablishedDate WHERE Id = @CustomerId"

                ' Create a MySqlCommand object and set the parameters
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@FullName", txtFullName.Text)
                command.Parameters.AddWithValue("@Address", txtAddress.Text)
                command.Parameters.AddWithValue("@Phone", txtPhone.Text)
                command.Parameters.AddWithValue("@Capital", txtCapital.Text)
                command.Parameters.AddWithValue("@EstablishedDate", dateEstablished.Value)
                command.Parameters.AddWithValue("@CustomerId", customerId)

                ' Execute update customer
                command.ExecuteNonQuery()

                CloseConnection(connection)

                MessageBox.Show("Saved Successfully")

            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while processing your request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            LoadCustomerList()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (String.IsNullOrEmpty(txtCustomerId.Text.Trim)) Then
                MessageBox.Show("Please select the row you want to delete")
                Return
            End If

            If (DialogResult.Yes = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) Then
                ' Get customer Id form view
                Dim customerId As Integer = Convert.ToInt32(txtCustomerId.Text)

                Using connection As MySqlConnection = GetConnection()
                    connection.Open()

                    Dim query As String = "DELETE FROM Customers WHERE Id = @CustomerId"

                    ' Create a MySqlCommand object and set the parameters
                    Dim command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@CustomerId", customerId)

                    ' Execute delete customer
                    command.ExecuteNonQuery()

                    CloseConnection(connection)
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while processing your request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            LoadCustomerList()
        End Try
    End Sub

    Private Sub dgvCustomer_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustomer.CellClick
        ' Get row selected and set value to text
        txtCustomerId.Text = dgvCustomer.Item(0, dgvCustomer.CurrentRow.Index).Value()
        txtFullName.Text = dgvCustomer.Item(2, dgvCustomer.CurrentRow.Index).Value()
        txtAddress.Text = dgvCustomer.Item(3, dgvCustomer.CurrentRow.Index).Value()
        txtPhone.Text = dgvCustomer.Item(4, dgvCustomer.CurrentRow.Index).Value()
        txtCapital.Text = dgvCustomer.Item(5, dgvCustomer.CurrentRow.Index).Value()
        dateEstablished.Text = dgvCustomer.Item(6, dgvCustomer.CurrentRow.Index).Value()
    End Sub
End Class
