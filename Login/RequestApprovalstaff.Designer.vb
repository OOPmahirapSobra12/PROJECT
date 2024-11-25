<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.dgvRequestApproval = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Course = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtreport = New System.Windows.Forms.TextBox()
        Me.txttime = New System.Windows.Forms.TextBox()
        Me.txtcourse = New System.Windows.Forms.TextBox()
        Me.txtroomno = New System.Windows.Forms.TextBox()
        Me.bntback = New System.Windows.Forms.Button()
        Me.bntsend = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvRequestApproval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRequestApproval
        '
        Me.dgvRequestApproval.AllowUserToAddRows = False
        Me.dgvRequestApproval.AllowUserToDeleteRows = False
        Me.dgvRequestApproval.BackgroundColor = System.Drawing.SystemColors.Highlight
        Me.dgvRequestApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequestApproval.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Course, Me.Column2, Me.Column3})
        Me.dgvRequestApproval.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvRequestApproval.Location = New System.Drawing.Point(76, 195)
        Me.dgvRequestApproval.Name = "dgvRequestApproval"
        Me.dgvRequestApproval.ReadOnly = True
        Me.dgvRequestApproval.RowHeadersWidth = 51
        Me.dgvRequestApproval.RowTemplate.Height = 24
        Me.dgvRequestApproval.Size = New System.Drawing.Size(551, 362)
        Me.dgvRequestApproval.TabIndex = 23
        '
        'Column1
        '
        Me.Column1.HeaderText = "Room No."
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Course
        '
        Me.Course.HeaderText = "Course"
        Me.Course.MinimumWidth = 6
        Me.Course.Name = "Course"
        Me.Course.ReadOnly = True
        Me.Course.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Time"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Report"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'txtreport
        '
        Me.txtreport.Location = New System.Drawing.Point(895, 451)
        Me.txtreport.Name = "txtreport"
        Me.txtreport.Size = New System.Drawing.Size(229, 22)
        Me.txtreport.TabIndex = 22
        '
        'txttime
        '
        Me.txttime.Location = New System.Drawing.Point(895, 393)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(229, 22)
        Me.txttime.TabIndex = 21
        '
        'txtcourse
        '
        Me.txtcourse.Location = New System.Drawing.Point(895, 325)
        Me.txtcourse.Name = "txtcourse"
        Me.txtcourse.Size = New System.Drawing.Size(229, 22)
        Me.txtcourse.TabIndex = 20
        '
        'txtroomno
        '
        Me.txtroomno.Location = New System.Drawing.Point(895, 252)
        Me.txtroomno.Name = "txtroomno"
        Me.txtroomno.Size = New System.Drawing.Size(224, 22)
        Me.txtroomno.TabIndex = 19
        '
        'bntback
        '
        Me.bntback.Location = New System.Drawing.Point(1023, 542)
        Me.bntback.Name = "bntback"
        Me.bntback.Size = New System.Drawing.Size(115, 50)
        Me.bntback.TabIndex = 18
        Me.bntback.Text = "Back"
        Me.bntback.UseVisualStyleBackColor = True
        '
        'bntsend
        '
        Me.bntsend.Location = New System.Drawing.Point(847, 542)
        Me.bntsend.Name = "bntsend"
        Me.bntsend.Size = New System.Drawing.Size(110, 49)
        Me.bntsend.TabIndex = 17
        Me.bntsend.Text = "Send"
        Me.bntsend.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(739, 449)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 24)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Report:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(739, 391)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(739, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Course:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(739, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Room No.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(217, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 32)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = """Request Approval"""
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Login.My.Resources.Resources.FB_IMG_1729211691620
        Me.ClientSize = New System.Drawing.Size(1232, 647)
        Me.Controls.Add(Me.dgvRequestApproval)
        Me.Controls.Add(Me.txtreport)
        Me.Controls.Add(Me.txttime)
        Me.Controls.Add(Me.txtcourse)
        Me.Controls.Add(Me.txtroomno)
        Me.Controls.Add(Me.bntback)
        Me.Controls.Add(Me.bntsend)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Request Approval"
        CType(Me.dgvRequestApproval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRequestApproval As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Course As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents txtreport As TextBox
    Friend WithEvents txttime As TextBox
    Friend WithEvents txtcourse As TextBox
    Friend WithEvents txtroomno As TextBox
    Friend WithEvents bntback As Button
    Friend WithEvents bntsend As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
