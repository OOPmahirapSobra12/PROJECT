<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accountlogs
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
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearchbox = New System.Windows.Forms.TextBox()
        Me.cbosearch = New System.Windows.Forms.ComboBox()
        Me.DGVaccountlogs = New System.Windows.Forms.DataGridView()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datein = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timein = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timeout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnback = New System.Windows.Forms.Button()
        CType(Me.DGVaccountlogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsearch
        '
        Me.btnsearch.AutoSize = True
        Me.btnsearch.BackColor = System.Drawing.Color.Transparent
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnsearch.Location = New System.Drawing.Point(458, 128)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(124, 35)
        Me.btnsearch.TabIndex = 13
        Me.btnsearch.Text = "btnsearch"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'txtsearchbox
        '
        Me.txtsearchbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.txtsearchbox.Location = New System.Drawing.Point(213, 128)
        Me.txtsearchbox.Name = "txtsearchbox"
        Me.txtsearchbox.Size = New System.Drawing.Size(239, 31)
        Me.txtsearchbox.TabIndex = 14
        '
        'cbosearch
        '
        Me.cbosearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cbosearch.FormattingEnabled = True
        Me.cbosearch.Items.AddRange(New Object() {"Choose:", "Username", "Date In", "Date Out", "Time In", "Time Out"})
        Me.cbosearch.Location = New System.Drawing.Point(74, 126)
        Me.cbosearch.Name = "cbosearch"
        Me.cbosearch.Size = New System.Drawing.Size(133, 33)
        Me.cbosearch.TabIndex = 15
        '
        'DGVaccountlogs
        '
        Me.DGVaccountlogs.AllowUserToAddRows = False
        Me.DGVaccountlogs.AllowUserToDeleteRows = False
        Me.DGVaccountlogs.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.DGVaccountlogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGVaccountlogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVaccountlogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.username, Me.datein, Me.timein, Me.dateout, Me.timeout})
        Me.DGVaccountlogs.GridColor = System.Drawing.Color.NavajoWhite
        Me.DGVaccountlogs.Location = New System.Drawing.Point(12, 169)
        Me.DGVaccountlogs.Name = "DGVaccountlogs"
        Me.DGVaccountlogs.ReadOnly = True
        Me.DGVaccountlogs.Size = New System.Drawing.Size(570, 242)
        Me.DGVaccountlogs.TabIndex = 12
        '
        'username
        '
        Me.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        '
        'datein
        '
        Me.datein.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.datein.HeaderText = "Date In"
        Me.datein.Name = "datein"
        Me.datein.ReadOnly = True
        '
        'timein
        '
        Me.timein.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.timein.HeaderText = "Time In"
        Me.timein.Name = "timein"
        Me.timein.ReadOnly = True
        '
        'dateout
        '
        Me.dateout.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dateout.HeaderText = "Date Out"
        Me.dateout.Name = "dateout"
        Me.dateout.ReadOnly = True
        '
        'timeout
        '
        Me.timeout.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.timeout.HeaderText = "Time Out"
        Me.timeout.Name = "timeout"
        Me.timeout.ReadOnly = True
        '
        'btnback
        '
        Me.btnback.AutoSize = True
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnback.Location = New System.Drawing.Point(261, 414)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(73, 35)
        Me.btnback.TabIndex = 86
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'accountlogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Login.My.Resources.Resources.FB_IMG_1729211691620
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(594, 450)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtsearchbox)
        Me.Controls.Add(Me.cbosearch)
        Me.Controls.Add(Me.DGVaccountlogs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "accountlogs"
        Me.Text = "accountlogs"
        CType(Me.DGVaccountlogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsearch As Button
    Friend WithEvents txtsearchbox As TextBox
    Friend WithEvents cbosearch As ComboBox
    Friend WithEvents DGVaccountlogs As DataGridView
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents datein As DataGridViewTextBoxColumn
    Friend WithEvents timein As DataGridViewTextBoxColumn
    Friend WithEvents dateout As DataGridViewTextBoxColumn
    Friend WithEvents timeout As DataGridViewTextBoxColumn
    Friend WithEvents btnback As Button
End Class
