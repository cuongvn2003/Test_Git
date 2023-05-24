Imports MySql.Data.MySqlClient

Public Class ContractEditFrm
    Private contractId As String = String.Empty

    ''' <summary>
    ''' Init form add/edit contract
    ''' </summary>
    ''' <param name="contract_id"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal contract_id As String)

        InitializeComponent()

        contractId = contract_id
    End Sub

    ''' <summary>
    ''' Set data to contract status combobox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PopulateStatusComboBox()
        ' Get the list of contract statuses
        Dim statusList As List(Of ListItem) = Common.GetContractStatusList()

        ' Clear the existing items in the ComboBox
        cbStatus.Items.Clear()

        ' Bind the status list to the ComboBox
        cbStatus.DataSource = statusList
        cbStatus.DisplayMember = "Text"
        cbStatus.ValueMember = "Value"

        ' Set the default selected item, if needed
        cbStatus.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' Set data to contract type combobox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PopulateTypeComboBox()
        ' Get the list of contract types
        Dim typeList As List(Of ListItem) = Common.GetContractTypeList()

        ' Clear the existing items in the ComboBox
        cbContractType.Items.Clear()

        ' Bind the type list to the ComboBox
        cbContractType.DataSource = typeList
        cbContractType.DisplayMember = "Text"
        cbContractType.ValueMember = "Value"

        ' Set the default selected item, if needed
        cbContractType.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' Set data to customer combobox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PopulateCustomerComboBox()
        ' Get the list of customers types
        Dim customerList As New List(Of ListItem)()

        Using connection As MySqlConnection = DatabaseHelper.GetConnection()
            connection.Open()

            Dim query As String = "SELECT * FROM Customers ORDER BY Id ASC "

            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        ' Mapping data customer
                        Dim cusotmerId As Integer = Convert.ToInt32(reader("Id"))

                        Dim cusotmerName As String = Convert.ToString(reader("FullName"))

                        customerList.Add(New ListItem(cusotmerName, cusotmerId))

                    End While
                End Using
            End Using

            DatabaseHelper.CloseConnection(connection)
        End Using

        ' Clear the existing items in the ComboBox
        cbCustomer.Items.Clear()

        ' Bind the customer list to the ComboBox
        cbCustomer.DataSource = customerList
        cbCustomer.DisplayMember = "Text"
        cbCustomer.ValueMember = "Value"

    End Sub

    ''' <summary>
    ''' Load data to form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ContractEditFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PopulateCustomerComboBox()

        PopulateStatusComboBox()

        PopulateTypeComboBox()

        If String.IsNullOrEmpty(contractId) Then
            RefreshForm()
            btnDelete.Enabled = False

            dateContract.Format = DateTimePickerFormat.Custom
            dateContract.CustomFormat = " "
        Else
            btnDelete.Enabled = True

            Using connection As MySqlConnection = DatabaseHelper.GetConnection()
                connection.Open()

                Dim query As String = "SELECT * FROM contracts WHERE Id = @ContractId"

                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@ContractId", contractId)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()

                            ' Mapping data contract detail

                            cbCustomer.SelectedValue = Convert.ToInt32(reader("CustomerId"))
                            txtBranchNumber.Text = Convert.ToString(reader("BranchNumber"))

                            If String.IsNullOrEmpty(reader("IsRenewable")) = False Then
                                If Constants.ContractRenewable.Yes = Convert.ToInt32(reader("IsRenewable")) Then
                                    rdRenewableYes.Checked = True
                                End If

                                If Constants.ContractRenewable.No = Convert.ToInt32(reader("IsRenewable")) Then
                                    rdRenewableNo.Checked = True
                                End If
                            End If
                            
                            cbContractType.SelectedValue = Convert.ToInt32(reader("ContractType"))
                            dateContract.Value = Convert.ToDateTime(reader("ContractDate"))
                            cbStatus.SelectedValue = Convert.ToInt32(reader("Status"))

                        End While
                    End Using
                End Using

                DatabaseHelper.CloseConnection(connection)
            End Using

        End If
    End Sub

    ''' <summary>
    ''' Refresh Form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RefreshForm()
        txtBranchNumber.Refresh()
        dateContract.Refresh()
    End Sub

    ''' <summary>
    ''' Add/edit contract
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Using connection As MySqlConnection = DatabaseHelper.GetConnection()
                connection.Open()

                Dim query As String = String.Empty
                If String.IsNullOrEmpty(contractId) Then
                    ' Set the query insert customer
                    query = "INSERT INTO Contracts (ContractNumber, BranchNumber, IsRenewable, ContractType, ContractDate, Status, CustomerId)" _
                            + " VALUES (@ContractNumber, @BranchNumber, @IsRenewable, @ContractType, @ContractDate, @Status, @CustomerId)"
                Else
                    ' Set the query update customer
                    query = "UPDATE Contracts SET ContractNumber = @ContractNumber, BranchNumber = @BranchNumber, IsRenewable = @IsRenewable," _
                        + " ContractType = @ContractType, ContractDate = @ContractDate, Status = @Status, CustomerId = @CustomerId WHERE Id = @ContractId"
                End If

                ' Create a MySqlCommand object and set the parameters
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@ContractNumber", "2023002")
                command.Parameters.AddWithValue("@BranchNumber", txtBranchNumber.Text)
                If rdRenewableYes.Checked = True Then
                    command.Parameters.AddWithValue("@IsRenewable", CInt(Constants.ContractRenewable.Yes))
                End If
                If rdRenewableNo.Checked = True Then
                    command.Parameters.AddWithValue("@IsRenewable", CInt(Constants.ContractRenewable.No))
                End If
                command.Parameters.AddWithValue("@ContractType", cbContractType.SelectedValue)
                command.Parameters.AddWithValue("@ContractDate", dateContract.Value)
                command.Parameters.AddWithValue("@Status", cbStatus.SelectedValue)
                command.Parameters.AddWithValue("@CustomerId", cbCustomer.SelectedValue)

                If String.IsNullOrEmpty(contractId) = False Then
                    command.Parameters.AddWithValue("@ContractId", contractId)
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

    ''' <summary>
    ''' Delete contract
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (DialogResult.Yes = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) Then
            Using connection As MySqlConnection = DatabaseHelper.GetConnection()
                connection.Open()

                Dim query As String = "DELETE FROM Contracts WHERE Id = @ContractId"

                ' Create a MySqlCommand object and set the parameters
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@ContractId", contractId)

                ' Execute delete customer
                command.ExecuteNonQuery()

                DatabaseHelper.CloseConnection(connection)
            End Using
        End If
    End Sub

    ''' <summary>
    ''' Close form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Set format DateTimePicker
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dateContract_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateContract.ValueChanged
        dateContract.Format = DateTimePickerFormat.Custom
        dateContract.CustomFormat = "yyyy/MM/dd"
    End Sub
End Class