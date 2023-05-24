Imports MySql.Data.MySqlClient

Public Class ContractListFrm

    Private lstContract As New List(Of Contract)

    ''' <summary>
    ''' Form load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ContractListFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtContractNumber.Focus()

        PopulateStatusComboBox()

        PopulateTypeComboBox()

        cbRenewable.SelectedIndex = 0

        dateContract.CustomFormat = " "

        LoadContractList()

        dgvContract.ClearSelection()

        dateContract.Format = DateTimePickerFormat.Custom
        dateContract.CustomFormat = " "

    End Sub

    ''' <summary>
    ''' Contract status comboBox
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
    ''' Contract type comboBox
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
    ''' Load list data contract
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadContractList()
        Try
            ' Refresh data Contract
            lstContract = New List(Of Contract)
            dgvContract.DataSource = Nothing

            Using connection As MySqlConnection = DatabaseHelper.GetConnection()
                connection.Open()

                Dim query As String = "SELECT * FROM Contracts"

                If (String.IsNullOrEmpty(txtContractNumber.Text) = False Or _
                    String.IsNullOrEmpty(txtBranchNumber.Text) = False Or _
                    cbRenewable.SelectedIndex > 0 Or _
                    cbContractType.SelectedValue > -1 Or _
                    cbStatus.SelectedValue > -1 Or _
                    String.IsNullOrEmpty(dateContract.Text.Trim) = False) Then

                    query += " WHERE "

                    If (String.IsNullOrEmpty(txtContractNumber.Text) = False) Then
                        query += " FullName LIKE @FullName "
                    End If
                    If (String.IsNullOrEmpty(txtBranchNumber.Text) = False) Then
                        query += " Address LIKE  @BranchNumber "
                    End If

                    If (cbRenewable.SelectedIndex > 0) Then
                        query += " IsRenewable =  @IsRenewable "
                    End If

                    If (cbContractType.SelectedValue > -1) Then
                        query += " ContractType =  @ContractType "
                    End If
                    If (cbStatus.SelectedValue > -1) Then
                        query += " Status =  @Status "
                    End If

                    If (String.IsNullOrEmpty(dateContract.Text.Trim) = False) Then
                        query += " DATE(ContractDate) =  @ContractDate "
                    End If

                End If

                Using command As New MySqlCommand(query, connection)

                    If (String.IsNullOrEmpty(txtContractNumber.Text) = False) Then
                        command.Parameters.AddWithValue("@FullName", "%" & txtContractNumber.Text & "%")
                    End If
                    If (String.IsNullOrEmpty(txtBranchNumber.Text) = False) Then
                        command.Parameters.AddWithValue("@BranchNumber", "%" & txtBranchNumber.Text & "%")
                    End If
                    If (cbRenewable.SelectedIndex > 0) Then
                        command.Parameters.AddWithValue("@IsRenewable", cbRenewable.SelectedIndex - 1)
                    End If
                    If (cbContractType.SelectedValue > -1) Then
                        command.Parameters.AddWithValue("@ContractType", cbContractType.SelectedValue)
                    End If
                    If (cbStatus.SelectedValue > -1) Then
                        command.Parameters.AddWithValue("@Status", cbStatus.SelectedValue)
                    End If
                    If (String.IsNullOrEmpty(dateContract.Text.Trim) = False) Then
                        command.Parameters.AddWithValue("@ContractDate", dateContract.Value.ToString("yyyy-MM-dd"))
                    End If

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()

                            ' Mapping data Contract detail
                            Dim contractId As Integer = Convert.ToInt32(reader("Id"))
                            Dim contractNumber As String = Convert.ToString(reader("ContractNumber"))
                            Dim branchNumber As String = Convert.ToString(reader("BranchNumber"))

                            Dim renewable As String = String.Empty
                            If String.IsNullOrEmpty(reader("IsRenewable")) = False Then
                                If Constants.ContractRenewable.Yes = Convert.ToInt32(reader("IsRenewable")) Then
                                    renewable = "Yes"
                                End If

                                If Constants.ContractRenewable.No = Convert.ToInt32(reader("IsRenewable")) Then
                                    renewable = "No"
                                End If
                            End If

                            Dim contractType As String = String.Empty
                            If String.IsNullOrEmpty(reader("ContractType")) = False Then
                                Select Case Convert.ToInt32(reader("ContractType"))
                                    Case CInt(Constants.ContractType.General)
                                        contractType = "General"
                                    Case CInt(Constants.ContractType.Car)
                                        contractType = "Car"
                                    Case CInt(Constants.ContractType.Soft)
                                        contractType = "Soft"
                                End Select
                            End If

                            Dim status As String = String.Empty
                            If String.IsNullOrEmpty(reader("Status")) = False Then
                                Select Case Convert.ToInt32(reader("Status"))
                                    Case CInt(Constants.ContractStatus.BeforeAcceptance)
                                        status = "Before Acceptance"
                                    Case CInt(Constants.ContractStatus.AcceptanceTesting)
                                        status = "Acceptance Testing"
                                    Case CInt(Constants.ContractStatus.ContractTermination)
                                        status = "Contract Termination"
                                    Case CInt(Constants.ContractStatus.ContractCancellation)
                                        status = "Contract Cancellation"
                                    Case CInt(Constants.ContractStatus.InstallmentPayment)
                                        status = "Installment Payment"
                                End Select
                            End If

                            Dim contractDate As DateTime = Convert.ToDateTime(reader("ContractDate")).ToString("yyyy/MM/dd")

                            ' Add columns filled in the Contract list.
                            lstContract.Add(New Contract(contractId, contractNumber, branchNumber, renewable, contractType, contractDate, status))

                        End While
                    End Using
                End Using

                DatabaseHelper.CloseConnection(connection)
            End Using

            If (lstContract.Count > 0) Then
                dgvContract.DataSource = lstContract
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the Contract list: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    ''' <summary>
    ''' Get row contract selected
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvContract_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvContract.CellClick
        txtContractId.Text = dgvContract.Item(0, dgvContract.CurrentRow.Index).Value()
    End Sub

    ''' <summary>
    ''' Show form add contract 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Try
            Dim contractEditFrm = New ContractEditFrm(String.Empty)
            contractEditFrm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("An error occurred while processing your request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            LoadContractList()
        End Try

        
    End Sub

    ''' <summary>
    ''' Show form edit contract 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If (String.IsNullOrEmpty(txtContractId.Text.Trim)) Then
                MessageBox.Show("Please select the row you want to update")
                Return
            End If

            Dim contractId As Integer = Convert.ToInt32(txtContractId.Text)

            Dim contractEditFrm = New ContractEditFrm(contractId)
            contractEditFrm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("An error occurred while processing your request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            LoadContractList()
        End Try
    End Sub

    ''' <summary>
    ''' Delete contract 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (String.IsNullOrEmpty(txtContractId.Text.Trim)) Then
                MessageBox.Show("Please select the row you want to delete")
                Return
            End If

            If (DialogResult.Yes = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) Then
                ' Get customer Id form view
                Dim contractId As Integer = Convert.ToInt32(txtContractId.Text.Trim)

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

        Catch ex As Exception
            MessageBox.Show("An error occurred while processing your request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            LoadContractList()
        End Try
    End Sub

    ''' <summary>
    ''' Search list contract 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadContractList()
    End Sub

    ''' <summary>
    ''' Reset form contract
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtContractNumber.Text = String.Empty
        txtBranchNumber.Text = String.Empty
        cbContractType.SelectedIndex = 0
        cbStatus.SelectedIndex = 0
        dateContract.Format = DateTimePickerFormat.Custom
        dateContract.CustomFormat = " "

        LoadContractList()
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