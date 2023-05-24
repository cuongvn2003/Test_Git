<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContractEditFrm
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbCustomer = New System.Windows.Forms.ComboBox()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.dateContract = New System.Windows.Forms.DateTimePicker()
        Me.lbContractDate = New System.Windows.Forms.Label()
        Me.cbContractType = New System.Windows.Forms.ComboBox()
        Me.lbContractType = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdRenewableYes = New System.Windows.Forms.RadioButton()
        Me.rdRenewableNo = New System.Windows.Forms.RadioButton()
        Me.txtBranchNumber = New System.Windows.Forms.TextBox()
        Me.lbBranchNumber = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbContractNumber = New System.Windows.Forms.Label()
        Me.txtContractNumber = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 353)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 65)
        Me.Panel1.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(286, 16)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 32)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(187, 16)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(83, 32)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(88, 16)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtContractNumber)
        Me.Panel2.Controls.Add(Me.cbCustomer)
        Me.Panel2.Controls.Add(Me.lbStatus)
        Me.Panel2.Controls.Add(Me.dateContract)
        Me.Panel2.Controls.Add(Me.lbContractDate)
        Me.Panel2.Controls.Add(Me.cbContractType)
        Me.Panel2.Controls.Add(Me.lbContractType)
        Me.Panel2.Controls.Add(Me.cbStatus)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.txtBranchNumber)
        Me.Panel2.Controls.Add(Me.lbBranchNumber)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lbContractNumber)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(452, 353)
        Me.Panel2.TabIndex = 1
        '
        'cbCustomer
        '
        Me.cbCustomer.FormattingEnabled = True
        Me.cbCustomer.Location = New System.Drawing.Point(136, 88)
        Me.cbCustomer.Name = "cbCustomer"
        Me.cbCustomer.Size = New System.Drawing.Size(196, 21)
        Me.cbCustomer.TabIndex = 23
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Location = New System.Drawing.Point(90, 299)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(37, 13)
        Me.lbStatus.TabIndex = 22
        Me.lbStatus.Text = "Status"
        '
        'dateContract
        '
        Me.dateContract.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateContract.Location = New System.Drawing.Point(136, 259)
        Me.dateContract.Name = "dateContract"
        Me.dateContract.Size = New System.Drawing.Size(129, 20)
        Me.dateContract.TabIndex = 21
        '
        'lbContractDate
        '
        Me.lbContractDate.AutoSize = True
        Me.lbContractDate.Location = New System.Drawing.Point(54, 263)
        Me.lbContractDate.Name = "lbContractDate"
        Me.lbContractDate.Size = New System.Drawing.Size(73, 13)
        Me.lbContractDate.TabIndex = 20
        Me.lbContractDate.Text = "Contract Date"
        '
        'cbContractType
        '
        Me.cbContractType.FormattingEnabled = True
        Me.cbContractType.Location = New System.Drawing.Point(136, 222)
        Me.cbContractType.Name = "cbContractType"
        Me.cbContractType.Size = New System.Drawing.Size(127, 21)
        Me.cbContractType.TabIndex = 19
        '
        'lbContractType
        '
        Me.lbContractType.AutoSize = True
        Me.lbContractType.Location = New System.Drawing.Point(53, 226)
        Me.lbContractType.Name = "lbContractType"
        Me.lbContractType.Size = New System.Drawing.Size(74, 13)
        Me.lbContractType.TabIndex = 18
        Me.lbContractType.Text = "Contract Type"
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(136, 295)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(127, 21)
        Me.cbStatus.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdRenewableYes)
        Me.GroupBox1.Controls.Add(Me.rdRenewableNo)
        Me.GroupBox1.Location = New System.Drawing.Point(69, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(196, 46)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Renewable"
        '
        'rdRenewableYes
        '
        Me.rdRenewableYes.AutoSize = True
        Me.rdRenewableYes.Location = New System.Drawing.Point(75, 19)
        Me.rdRenewableYes.Name = "rdRenewableYes"
        Me.rdRenewableYes.Size = New System.Drawing.Size(43, 17)
        Me.rdRenewableYes.TabIndex = 13
        Me.rdRenewableYes.TabStop = True
        Me.rdRenewableYes.Text = "Yes"
        Me.rdRenewableYes.UseVisualStyleBackColor = True
        '
        'rdRenewableNo
        '
        Me.rdRenewableNo.AutoSize = True
        Me.rdRenewableNo.Location = New System.Drawing.Point(133, 19)
        Me.rdRenewableNo.Name = "rdRenewableNo"
        Me.rdRenewableNo.Size = New System.Drawing.Size(39, 17)
        Me.rdRenewableNo.TabIndex = 14
        Me.rdRenewableNo.TabStop = True
        Me.rdRenewableNo.Text = "No"
        Me.rdRenewableNo.UseVisualStyleBackColor = True
        '
        'txtBranchNumber
        '
        Me.txtBranchNumber.Location = New System.Drawing.Point(136, 124)
        Me.txtBranchNumber.Name = "txtBranchNumber"
        Me.txtBranchNumber.Size = New System.Drawing.Size(127, 20)
        Me.txtBranchNumber.TabIndex = 6
        '
        'lbBranchNumber
        '
        Me.lbBranchNumber.AutoSize = True
        Me.lbBranchNumber.Location = New System.Drawing.Point(46, 128)
        Me.lbBranchNumber.Name = "lbBranchNumber"
        Me.lbBranchNumber.Size = New System.Drawing.Size(81, 13)
        Me.lbBranchNumber.TabIndex = 5
        Me.lbBranchNumber.Text = "Branch Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer"
        '
        'lbContractNumber
        '
        Me.lbContractNumber.AutoSize = True
        Me.lbContractNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbContractNumber.Location = New System.Drawing.Point(112, 30)
        Me.lbContractNumber.Name = "lbContractNumber"
        Me.lbContractNumber.Size = New System.Drawing.Size(210, 20)
        Me.lbContractNumber.TabIndex = 0
        Me.lbContractNumber.Text = "Contract Number: 20230001"
        '
        'txtContractNumber
        '
        Me.txtContractNumber.Location = New System.Drawing.Point(404, 30)
        Me.txtContractNumber.Name = "txtContractNumber"
        Me.txtContractNumber.Size = New System.Drawing.Size(45, 20)
        Me.txtContractNumber.TabIndex = 24
        Me.txtContractNumber.Visible = False
        '
        'ContractEditFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 418)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ContractEditFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ContractEditFrm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lbContractNumber As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBranchNumber As System.Windows.Forms.TextBox
    Friend WithEvents lbBranchNumber As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdRenewableYes As System.Windows.Forms.RadioButton
    Friend WithEvents rdRenewableNo As System.Windows.Forms.RadioButton
    Friend WithEvents cbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents lbStatus As System.Windows.Forms.Label
    Friend WithEvents dateContract As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbContractDate As System.Windows.Forms.Label
    Friend WithEvents cbContractType As System.Windows.Forms.ComboBox
    Friend WithEvents lbContractType As System.Windows.Forms.Label
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtContractNumber As System.Windows.Forms.TextBox
End Class
