<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTtlCommission = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkOver10 = New System.Windows.Forms.CheckBox()
        Me.chkTraveling = New System.Windows.Forms.CheckBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Sales:"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(12, 41)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(197, 24)
        Me.txtSales.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(153, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total commission:"
        '
        'lblTtlCommission
        '
        Me.lblTtlCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTtlCommission.Location = New System.Drawing.Point(15, 146)
        Me.lblTtlCommission.Name = "lblTtlCommission"
        Me.lblTtlCommission.Size = New System.Drawing.Size(411, 71)
        Me.lblTtlCommission.TabIndex = 3
        Me.lblTtlCommission.Text = " "
        Me.lblTtlCommission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkTraveling)
        Me.GroupBox1.Controls.Add(Me.chkOver10)
        Me.GroupBox1.Location = New System.Drawing.Point(226, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'chkOver10
        '
        Me.chkOver10.AutoSize = True
        Me.chkOver10.Location = New System.Drawing.Point(48, 24)
        Me.chkOver10.Name = "chkOver10"
        Me.chkOver10.Size = New System.Drawing.Size(119, 22)
        Me.chkOver10.TabIndex = 0
        Me.chkOver10.Text = "&Over 10 years"
        Me.chkOver10.UseVisualStyleBackColor = True
        '
        'chkTraveling
        '
        Me.chkTraveling.AutoSize = True
        Me.chkTraveling.Location = New System.Drawing.Point(48, 54)
        Me.chkTraveling.Name = "chkTraveling"
        Me.chkTraveling.Size = New System.Drawing.Size(86, 22)
        Me.chkTraveling.TabIndex = 1
        Me.chkTraveling.Text = "&Traveling"
        Me.chkTraveling.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(15, 73)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(94, 36)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(115, 73)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 36)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 227)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTtlCommission)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marshall Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTtlCommission As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkTraveling As CheckBox
    Friend WithEvents chkOver10 As CheckBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
