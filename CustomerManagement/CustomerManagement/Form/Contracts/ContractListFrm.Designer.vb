<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContractListFrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbRenewable = New System.Windows.Forms.Label()
        Me.cbRenewable = New System.Windows.Forms.ComboBox()
        Me.txtContractId = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.dateContract = New System.Windows.Forms.DateTimePicker()
        Me.lbContractDate = New System.Windows.Forms.Label()
        Me.cbContractType = New System.Windows.Forms.ComboBox()
        Me.lbContractType = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.txtBranchNumber = New System.Windows.Forms.TextBox()
        Me.lbBranchNumber = New System.Windows.Forms.Label()
        Me.txtContractNumber = New System.Windows.Forms.TextBox()
        Me.lbContractNumber = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvContract = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsRenewable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvContract, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbRenewable)
        Me.Panel1.Controls.Add(Me.cbRenewable)
        Me.Panel1.Controls.Add(Me.txtContractId)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.lbStatus)
        Me.Panel1.Controls.Add(Me.dateContract)
        Me.Panel1.Controls.Add(Me.lbContractDate)
        Me.Panel1.Controls.Add(Me.cbContractType)
        Me.Panel1.Controls.Add(Me.lbContractType)
        Me.Panel1.Controls.Add(Me.cbStatus)
        Me.Panel1.Controls.Add(Me.txtBranchNumber)
        Me.Panel1.Controls.Add(Me.lbBranchNumber)
        Me.Panel1.Controls.Add(Me.txtContractNumber)
        Me.Panel1.Controls.Add(Me.lbContractNumber)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 213)
        Me.Panel1.TabIndex = 0
        '
        'lbRenewable
        '
        Me.lbRenewable.AutoSize = True
        Me.lbRenewable.Location = New System.Drawing.Point(61, 157)
        Me.lbRenewable.Name = "lbRenewable"
        Me.lbRenewable.Size = New System.Drawing.Size(61, 13)
        Me.lbRenewable.TabIndex = 21
        Me.lbRenewable.Text = "Renewable"
        '
        'cbRenewable
        '
        Me.cbRenewable.FormattingEnabled = True
        Me.cbRenewable.Items.AddRange(New Object() {"-- Choose --", "No", "Yes"})
        Me.cbRenewable.Location = New System.Drawing.Point(134, 153)
        Me.cbRenewable.Name = "cbRenewable"
        Me.cbRenewable.Size = New System.Drawing.Size(106, 21)
        Me.cbRenewable.TabIndex = 20
        '
        'txtContractId
        '
        Me.txtContractId.Location = New System.Drawing.Point(672, 87)
        Me.txtContractId.Name = "txtContractId"
        Me.txtContractId.Size = New System.Drawing.Size(106, 20)
        Me.txtContractId.TabIndex = 19
        Me.txtContractId.Visible = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(558, 141)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 34)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(558, 83)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 34)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Location = New System.Drawing.Point(335, 157)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(37, 13)
        Me.lbStatus.TabIndex = 12
        Me.lbStatus.Text = "Status"
        '
        'dateContract
        '
        Me.dateContract.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateContract.Location = New System.Drawing.Point(383, 119)
        Me.dateContract.Name = "dateContract"
        Me.dateContract.Size = New System.Drawing.Size(127, 20)
        Me.dateContract.TabIndex = 11
        '
        'lbContractDate
        '
        Me.lbContractDate.AutoSize = True
        Me.lbContractDate.Location = New System.Drawing.Point(299, 123)
        Me.lbContractDate.Name = "lbContractDate"
        Me.lbContractDate.Size = New System.Drawing.Size(73, 13)
        Me.lbContractDate.TabIndex = 10
        Me.lbContractDate.Text = "Contract Date"
        '
        'cbContractType
        '
        Me.cbContractType.FormattingEnabled = True
        Me.cbContractType.Location = New System.Drawing.Point(383, 83)
        Me.cbContractType.Name = "cbContractType"
        Me.cbContractType.Size = New System.Drawing.Size(127, 21)
        Me.cbContractType.TabIndex = 9
        '
        'lbContractType
        '
        Me.lbContractType.AutoSize = True
        Me.lbContractType.Location = New System.Drawing.Point(298, 87)
        Me.lbContractType.Name = "lbContractType"
        Me.lbContractType.Size = New System.Drawing.Size(74, 13)
        Me.lbContractType.TabIndex = 8
        Me.lbContractType.Text = "Contract Type"
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(383, 153)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(127, 21)
        Me.cbStatus.TabIndex = 7
        '
        'txtBranchNumber
        '
        Me.txtBranchNumber.Location = New System.Drawing.Point(134, 119)
        Me.txtBranchNumber.Name = "txtBranchNumber"
        Me.txtBranchNumber.Size = New System.Drawing.Size(106, 20)
        Me.txtBranchNumber.TabIndex = 4
        '
        'lbBranchNumber
        '
        Me.lbBranchNumber.AutoSize = True
        Me.lbBranchNumber.Location = New System.Drawing.Point(41, 123)
        Me.lbBranchNumber.Name = "lbBranchNumber"
        Me.lbBranchNumber.Size = New System.Drawing.Size(81, 13)
        Me.lbBranchNumber.TabIndex = 3
        Me.lbBranchNumber.Text = "Branch Number"
        '
        'txtContractNumber
        '
        Me.txtContractNumber.Location = New System.Drawing.Point(134, 83)
        Me.txtContractNumber.Name = "txtContractNumber"
        Me.txtContractNumber.Size = New System.Drawing.Size(106, 20)
        Me.txtContractNumber.TabIndex = 2
        '
        'lbContractNumber
        '
        Me.lbContractNumber.AutoSize = True
        Me.lbContractNumber.Location = New System.Drawing.Point(41, 87)
        Me.lbContractNumber.Name = "lbContractNumber"
        Me.lbContractNumber.Size = New System.Drawing.Size(87, 13)
        Me.lbContractNumber.TabIndex = 1
        Me.lbContractNumber.Text = "Contract Number"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnDelete)
        Me.Panel3.Controls.Add(Me.btnAdd)
        Me.Panel3.Controls.Add(Me.btnEdit)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(802, 61)
        Me.Panel3.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(238, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 34)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(44, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 34)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(141, 12)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 34)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvContract)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 213)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(802, 372)
        Me.Panel2.TabIndex = 1
        '
        'dgvContract
        '
        Me.dgvContract.AllowUserToAddRows = False
        Me.dgvContract.AllowUserToDeleteRows = False
        Me.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContract.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.ContractNumber, Me.BranchNumber, Me.IsRenewable, Me.ContractType, Me.ContractDate, Me.Status})
        Me.dgvContract.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvContract.Location = New System.Drawing.Point(0, 0)
        Me.dgvContract.Name = "dgvContract"
        Me.dgvContract.ReadOnly = True
        Me.dgvContract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContract.Size = New System.Drawing.Size(802, 372)
        Me.dgvContract.TabIndex = 0
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 50
        '
        'ContractNumber
        '
        Me.ContractNumber.DataPropertyName = "ContractNumber"
        Me.ContractNumber.HeaderText = "Contract Number"
        Me.ContractNumber.Name = "ContractNumber"
        Me.ContractNumber.ReadOnly = True
        Me.ContractNumber.Width = 120
        '
        'BranchNumber
        '
        Me.BranchNumber.DataPropertyName = "BranchNumber"
        Me.BranchNumber.HeaderText = "Branch Number"
        Me.BranchNumber.Name = "BranchNumber"
        Me.BranchNumber.ReadOnly = True
        Me.BranchNumber.Width = 120
        '
        'IsRenewable
        '
        Me.IsRenewable.DataPropertyName = "IsRenewable"
        Me.IsRenewable.HeaderText = "Renewable"
        Me.IsRenewable.Name = "IsRenewable"
        Me.IsRenewable.ReadOnly = True
        '
        'ContractType
        '
        Me.ContractType.DataPropertyName = "ContractType"
        Me.ContractType.HeaderText = "Contract Type"
        Me.ContractType.Name = "ContractType"
        Me.ContractType.ReadOnly = True
        Me.ContractType.Width = 200
        '
        'ContractDate
        '
        Me.ContractDate.DataPropertyName = "ContractDate"
        Me.ContractDate.HeaderText = "Contract Date"
        Me.ContractDate.Name = "ContractDate"
        Me.ContractDate.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'ContractListFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 585)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ContractListFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contract List"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvContract, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvContract As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents lbContractNumber As System.Windows.Forms.Label
    Friend WithEvents txtBranchNumber As System.Windows.Forms.TextBox
    Friend WithEvents lbBranchNumber As System.Windows.Forms.Label
    Friend WithEvents txtContractNumber As System.Windows.Forms.TextBox
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cbContractType As System.Windows.Forms.ComboBox
    Friend WithEvents lbContractType As System.Windows.Forms.Label
    Friend WithEvents dateContract As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbContractDate As System.Windows.Forms.Label
    Friend WithEvents lbStatus As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtContractId As System.Windows.Forms.TextBox
    Friend WithEvents lbRenewable As System.Windows.Forms.Label
    Friend WithEvents cbRenewable As System.Windows.Forms.ComboBox
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContractNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BranchNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsRenewable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContractType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContractDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
