<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerEditFrm
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
        Me.dateEstablished = New System.Windows.Forms.DateTimePicker()
        Me.lbDateEstablishment = New System.Windows.Forms.Label()
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.lbAuthorisedCapital = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lbPhone = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lbAddress = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lbFullName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dateEstablished)
        Me.Panel1.Controls.Add(Me.lbDateEstablishment)
        Me.Panel1.Controls.Add(Me.txtCapital)
        Me.Panel1.Controls.Add(Me.lbAuthorisedCapital)
        Me.Panel1.Controls.Add(Me.txtPhone)
        Me.Panel1.Controls.Add(Me.lbPhone)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.lbAddress)
        Me.Panel1.Controls.Add(Me.txtFullName)
        Me.Panel1.Controls.Add(Me.lbFullName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(567, 261)
        Me.Panel1.TabIndex = 0
        '
        'dateEstablished
        '
        Me.dateEstablished.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateEstablished.Location = New System.Drawing.Point(150, 164)
        Me.dateEstablished.Name = "dateEstablished"
        Me.dateEstablished.Size = New System.Drawing.Size(154, 20)
        Me.dateEstablished.TabIndex = 25
        '
        'lbDateEstablishment
        '
        Me.lbDateEstablishment.AutoSize = True
        Me.lbDateEstablishment.Location = New System.Drawing.Point(33, 168)
        Me.lbDateEstablishment.Name = "lbDateEstablishment"
        Me.lbDateEstablishment.Size = New System.Drawing.Size(109, 13)
        Me.lbDateEstablishment.TabIndex = 24
        Me.lbDateEstablishment.Text = "Date of establishment"
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(150, 128)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(154, 20)
        Me.txtCapital.TabIndex = 22
        '
        'lbAuthorisedCapital
        '
        Me.lbAuthorisedCapital.AutoSize = True
        Me.lbAuthorisedCapital.Location = New System.Drawing.Point(103, 132)
        Me.lbAuthorisedCapital.Name = "lbAuthorisedCapital"
        Me.lbAuthorisedCapital.Size = New System.Drawing.Size(39, 13)
        Me.lbAuthorisedCapital.TabIndex = 23
        Me.lbAuthorisedCapital.Text = "Capital"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(150, 94)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(154, 20)
        Me.txtPhone.TabIndex = 20
        '
        'lbPhone
        '
        Me.lbPhone.AutoSize = True
        Me.lbPhone.Location = New System.Drawing.Point(104, 98)
        Me.lbPhone.Name = "lbPhone"
        Me.lbPhone.Size = New System.Drawing.Size(38, 13)
        Me.lbPhone.TabIndex = 21
        Me.lbPhone.Text = "Phone"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(150, 58)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(324, 20)
        Me.txtAddress.TabIndex = 18
        '
        'lbAddress
        '
        Me.lbAddress.AutoSize = True
        Me.lbAddress.Location = New System.Drawing.Point(97, 62)
        Me.lbAddress.Name = "lbAddress"
        Me.lbAddress.Size = New System.Drawing.Size(45, 13)
        Me.lbAddress.TabIndex = 19
        Me.lbAddress.Text = "Address"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(150, 21)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(154, 20)
        Me.txtFullName.TabIndex = 16
        '
        'lbFullName
        '
        Me.lbFullName.AutoSize = True
        Me.lbFullName.Location = New System.Drawing.Point(91, 25)
        Me.lbFullName.Name = "lbFullName"
        Me.lbFullName.Size = New System.Drawing.Size(51, 13)
        Me.lbFullName.TabIndex = 17
        Me.lbFullName.Text = "FullName"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 205)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(567, 56)
        Me.Panel2.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(334, 12)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 32)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(237, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(83, 32)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(137, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'CustomerEditFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 261)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CustomerEditFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerEditForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dateEstablished As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbDateEstablishment As System.Windows.Forms.Label
    Friend WithEvents txtCapital As System.Windows.Forms.TextBox
    Friend WithEvents lbAuthorisedCapital As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lbPhone As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lbAddress As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lbFullName As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
