<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerListFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lbFullName = New System.Windows.Forms.Label()
        Me.panelCustomerInfo = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtCustomerId = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.dateEstablished = New System.Windows.Forms.DateTimePicker()
        Me.lbDateEstablishment = New System.Windows.Forms.Label()
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.lbAuthorisedCapital = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lbPhone = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lbAddress = New System.Windows.Forms.Label()
        Me.panelCustomerList = New System.Windows.Forms.Panel()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Captial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstablishedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.panelCustomerInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelCustomerList.SuspendLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(79, 61)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(154, 20)
        Me.txtFullName.TabIndex = 0
        '
        'lbFullName
        '
        Me.lbFullName.AutoSize = True
        Me.lbFullName.Location = New System.Drawing.Point(20, 65)
        Me.lbFullName.Name = "lbFullName"
        Me.lbFullName.Size = New System.Drawing.Size(51, 13)
        Me.lbFullName.TabIndex = 1
        Me.lbFullName.Text = "FullName"
        '
        'panelCustomerInfo
        '
        Me.panelCustomerInfo.Controls.Add(Me.btnReset)
        Me.panelCustomerInfo.Controls.Add(Me.btnSearch)
        Me.panelCustomerInfo.Controls.Add(Me.txtCustomerId)
        Me.panelCustomerInfo.Controls.Add(Me.Panel1)
        Me.panelCustomerInfo.Controls.Add(Me.dateEstablished)
        Me.panelCustomerInfo.Controls.Add(Me.lbDateEstablishment)
        Me.panelCustomerInfo.Controls.Add(Me.txtCapital)
        Me.panelCustomerInfo.Controls.Add(Me.lbAuthorisedCapital)
        Me.panelCustomerInfo.Controls.Add(Me.txtPhone)
        Me.panelCustomerInfo.Controls.Add(Me.lbPhone)
        Me.panelCustomerInfo.Controls.Add(Me.txtAddress)
        Me.panelCustomerInfo.Controls.Add(Me.lbAddress)
        Me.panelCustomerInfo.Controls.Add(Me.txtFullName)
        Me.panelCustomerInfo.Controls.Add(Me.lbFullName)
        Me.panelCustomerInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelCustomerInfo.Location = New System.Drawing.Point(0, 0)
        Me.panelCustomerInfo.Name = "panelCustomerInfo"
        Me.panelCustomerInfo.Size = New System.Drawing.Size(772, 153)
        Me.panelCustomerInfo.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(660, 61)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 34)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtCustomerId
        '
        Me.txtCustomerId.Location = New System.Drawing.Point(519, 61)
        Me.txtCustomerId.Name = "txtCustomerId"
        Me.txtCustomerId.Size = New System.Drawing.Size(114, 20)
        Me.txtCustomerId.TabIndex = 15
        Me.txtCustomerId.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 50)
        Me.Panel1.TabIndex = 14
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(273, 9)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 34)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(79, 9)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 34)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(176, 9)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 34)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'dateEstablished
        '
        Me.dateEstablished.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateEstablished.Location = New System.Drawing.Point(519, 118)
        Me.dateEstablished.Name = "dateEstablished"
        Me.dateEstablished.Size = New System.Drawing.Size(114, 20)
        Me.dateEstablished.TabIndex = 10
        '
        'lbDateEstablishment
        '
        Me.lbDateEstablishment.AutoSize = True
        Me.lbDateEstablishment.Location = New System.Drawing.Point(402, 122)
        Me.lbDateEstablishment.Name = "lbDateEstablishment"
        Me.lbDateEstablishment.Size = New System.Drawing.Size(109, 13)
        Me.lbDateEstablishment.TabIndex = 9
        Me.lbDateEstablishment.Text = "Date of establishment"
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(519, 90)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(114, 20)
        Me.txtCapital.TabIndex = 6
        '
        'lbAuthorisedCapital
        '
        Me.lbAuthorisedCapital.AutoSize = True
        Me.lbAuthorisedCapital.Location = New System.Drawing.Point(472, 94)
        Me.lbAuthorisedCapital.Name = "lbAuthorisedCapital"
        Me.lbAuthorisedCapital.Size = New System.Drawing.Size(39, 13)
        Me.lbAuthorisedCapital.TabIndex = 7
        Me.lbAuthorisedCapital.Text = "Capital"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(79, 118)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(154, 20)
        Me.txtPhone.TabIndex = 4
        '
        'lbPhone
        '
        Me.lbPhone.AutoSize = True
        Me.lbPhone.Location = New System.Drawing.Point(33, 122)
        Me.lbPhone.Name = "lbPhone"
        Me.lbPhone.Size = New System.Drawing.Size(38, 13)
        Me.lbPhone.TabIndex = 5
        Me.lbPhone.Text = "Phone"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(79, 90)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(288, 20)
        Me.txtAddress.TabIndex = 2
        '
        'lbAddress
        '
        Me.lbAddress.AutoSize = True
        Me.lbAddress.Location = New System.Drawing.Point(26, 94)
        Me.lbAddress.Name = "lbAddress"
        Me.lbAddress.Size = New System.Drawing.Size(45, 13)
        Me.lbAddress.TabIndex = 3
        Me.lbAddress.Text = "Address"
        '
        'panelCustomerList
        '
        Me.panelCustomerList.Controls.Add(Me.dgvCustomer)
        Me.panelCustomerList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCustomerList.Location = New System.Drawing.Point(0, 153)
        Me.panelCustomerList.Name = "panelCustomerList"
        Me.panelCustomerList.Size = New System.Drawing.Size(772, 363)
        Me.panelCustomerList.TabIndex = 3
        '
        'dgvCustomer
        '
        Me.dgvCustomer.AllowUserToAddRows = False
        Me.dgvCustomer.AllowUserToDeleteRows = False
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.FullName, Me.Address, Me.Phone, Me.Captial, Me.EstablishedDate})
        Me.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCustomer.Location = New System.Drawing.Point(0, 0)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.ReadOnly = True
        Me.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomer.Size = New System.Drawing.Size(772, 363)
        Me.dgvCustomer.TabIndex = 0
        '
        'ID
        '
        Me.ID.DataPropertyName = "Id"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'FullName
        '
        Me.FullName.DataPropertyName = "FullName"
        Me.FullName.HeaderText = "FullName"
        Me.FullName.Name = "FullName"
        Me.FullName.ReadOnly = True
        Me.FullName.Width = 150
        '
        'Address
        '
        Me.Address.DataPropertyName = "Address"
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Width = 200
        '
        'Phone
        '
        Me.Phone.DataPropertyName = "Phone"
        Me.Phone.HeaderText = "Phone"
        Me.Phone.Name = "Phone"
        Me.Phone.ReadOnly = True
        '
        'Captial
        '
        Me.Captial.DataPropertyName = "Capital"
        Me.Captial.HeaderText = "Captial"
        Me.Captial.Name = "Captial"
        Me.Captial.ReadOnly = True
        '
        'EstablishedDate
        '
        Me.EstablishedDate.DataPropertyName = "EstablishedDate"
        Me.EstablishedDate.HeaderText = "Date of establishment"
        Me.EstablishedDate.Name = "EstablishedDate"
        Me.EstablishedDate.ReadOnly = True
        Me.EstablishedDate.Width = 150
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(660, 108)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 34)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'CustomerManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 516)
        Me.Controls.Add(Me.panelCustomerList)
        Me.Controls.Add(Me.panelCustomerInfo)
        Me.Name = "CustomerManagementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerManagementForm"
        Me.panelCustomerInfo.ResumeLayout(False)
        Me.panelCustomerInfo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.panelCustomerList.ResumeLayout(False)
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lbFullName As System.Windows.Forms.Label
    Friend WithEvents panelCustomerInfo As System.Windows.Forms.Panel
    Friend WithEvents lbDateEstablishment As System.Windows.Forms.Label
    Friend WithEvents txtCapital As System.Windows.Forms.TextBox
    Friend WithEvents lbAuthorisedCapital As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lbPhone As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lbAddress As System.Windows.Forms.Label
    Friend WithEvents panelCustomerList As System.Windows.Forms.Panel
    Friend WithEvents dateEstablished As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents dgvCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtCustomerId As System.Windows.Forms.TextBox
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Phone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Captial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstablishedDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
End Class
