<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenuFrm
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
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnContract = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(115, 40)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(88, 46)
        Me.btnCustomer.TabIndex = 0
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnContract
        '
        Me.btnContract.Location = New System.Drawing.Point(240, 43)
        Me.btnContract.Name = "btnContract"
        Me.btnContract.Size = New System.Drawing.Size(102, 43)
        Me.btnContract.TabIndex = 1
        Me.btnContract.Text = "Contract"
        Me.btnContract.UseVisualStyleBackColor = True
        '
        'MainMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 310)
        Me.Controls.Add(Me.btnContract)
        Me.Controls.Add(Me.btnCustomer)
        Me.Name = "MainMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenuForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents btnContract As System.Windows.Forms.Button
End Class
