Imports MySql.Data.MySqlClient

Public Class CustomerListFrm

    Private connectionString As String = "Server=127.0.0.1;Database=lease_package;Uid=root;Pwd=123456;"

    Private lstCustomer As New List(Of Customer)

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadCustomerList()
        Try
            ' Refresh data customer
            lstCustomer = New List(Of Customer)
            dgvCustomer.DataSource = Nothing

            Using connection As MySqlConnection = DatabaseHelper.GetConnection()
                connection.Open()

                Dim query As String = "SELECT * FROM Customers"

                If (String.IsNullOrEmpty(txtFullName.Text) = False Or _
                    String.IsNullOrEmpty(txtAddress.Text) = False Or _
                    String.IsNullOrEmpty(txtPhone.Text) = False Or _
                    String.IsNullOrEmpty(txtCapital.Text) = False) Then

                    query += " WHERE "

                    If (String.IsNullOrEmpty(txtFullName.Text) = False) Then
                        query += " FullName LIKE @FullName "
                    End If
                    If (String.IsNullOrEmpty(txtAddress.Text) = False) Then
                        query += " Address LIKE  Address "
                    End If
                    If (String.IsNullOrEmpty(txtPhone.Text) = False) Then
                        query += " Phone LIKE  @Phone "
                    End If
                    If (String.IsNullOrEmpty(txtCapital.Text) = False) Then
                        query += " Capital == @Capital "
                    End If

                End If

                Using command As New MySqlCommand(query, connection)

                    If (String.IsNullOrEmpty(txtFullName.Text) = False) Then
                        command.Parameters.AddWithValue("@FullName", "%" & txtFullName.Text & "%")
                    End If
                    If (String.IsNullOrEmpty(txtAddress.Text) = False) Then
                        command.Parameters.AddWithValue("@Address", "%" & txtAddress.Text & "%")
                    End If
                    If (String.IsNullOrEmpty(txtPhone.Text) = False) Then
                        command.Parameters.AddWithValue("@Phone", "%" & txtPhone.Text)
                    End If
                    If (String.IsNullOrEmpty(txtCapital.Text) = False) Then
                        command.Parameters.AddWithValue("@Capital", txtCapital.Text)
                    End If

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()

                            ' Mapping data customer detail
                            Dim customerId As Integer = Convert.ToInt32(reader("Id"))
                            Dim fullName As String = Convert.ToString(reader("FullName"))
                            Dim address As String = Convert.ToString(reader("Address"))
                            Dim phone As String = Convert.ToString(reader("Phone"))
                            Dim capital As String = Convert.ToString(reader("Capital"))
                            Dim established As DateTime = Convert.ToDateTime(reader("EstablishedDate")).ToString("yyyy/MM/dd")

                            ' Add columns filled in the customer list.
                            lstCustomer.Add(New Customer(customerId, fullName, address, phone, capital, established))

                        End While
                    End Using
                End Using

                DatabaseHelper.CloseConnection(connection)
            End Using

            If (lstCustomer.Count > 0) Then
                dgvCustomer.DataSource = lstCustomer
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the customer list: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CustomerManagementForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtFullName.Focus()

        LoadCustomerList()

        dgvCustomer.ClearSelection()

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim customerEditFrm = New CustomerEditFrm(String.Empty)
        customerEditFrm.ShowDialog()

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If (String.IsNullOrEmpty(txtCustomerId.Text.Trim)) Then
                MessageBox.Show("Please select the row you want to update")
                Return
            End If

            Dim customerId As Integer = Convert.ToInt32(txtCustomerId.Text)

            Dim customerEditFrm = New CustomerEditFrm(customerId)
            customerEditFrm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("An error occurred while processing your request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            LoadCustomerList()
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (String.IsNullOrEmpty(txtCustomerId.Text.Trim)) Then
                MessageBox.Show("Please select the row you want to delete")
                Return
            End If

            If (DialogResult.Yes = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) Then
                ' Get customer Id form view
                Dim customerId As Integer = Convert.ToInt32(txtCustomerId.Text)

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

        Catch ex As Exception
            MessageBox.Show("An error occurred while processing your request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            LoadCustomerList()
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvCustomer_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustomer.CellClick
        ' Get row selected and set value to text
        txtCustomerId.Text = dgvCustomer.Item(0, dgvCustomer.CurrentRow.Index).Value()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadCustomerList()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtCustomerId.Text = String.Empty
        txtFullName.Text = String.Empty
        txtAddress.Text = String.Empty
        txtPhone.Text = String.Empty
        txtCapital.Text = String.Empty
        dateEstablished.Text = String.Empty
    End Sub
End Class
