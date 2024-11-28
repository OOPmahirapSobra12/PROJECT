<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class accountlogs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbosearch = New System.Windows.Forms.ComboBox()
        Me.txtsearchbox = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.DGVaccountlogs = New System.Windows.Forms.DataGridView()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datein = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timein = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timeout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnback = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DGVaccountlogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.22222!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.77778!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(594, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DGVaccountlogs, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 84)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.77778!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.09621!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.41108!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.623907!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(588, 363)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.81482!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.03704!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.14815!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.cbosearch, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtsearchbox, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnsearch, 3, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(582, 47)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'cbosearch
        '
        Me.cbosearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbosearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbosearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cbosearch.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbosearch.FormattingEnabled = True
        Me.cbosearch.Items.AddRange(New Object() {"Choose:", "Username", "Date In", "Date Out", "Time In", "Time Out"})
        Me.cbosearch.Location = New System.Drawing.Point(23, 3)
        Me.cbosearch.Name = "cbosearch"
        Me.cbosearch.Size = New System.Drawing.Size(149, 33)
        Me.cbosearch.TabIndex = 91
        '
        'txtsearchbox
        '
        Me.txtsearchbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtsearchbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtsearchbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.txtsearchbox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtsearchbox.Location = New System.Drawing.Point(178, 3)
        Me.txtsearchbox.Name = "txtsearchbox"
        Me.txtsearchbox.Size = New System.Drawing.Size(240, 31)
        Me.txtsearchbox.TabIndex = 92
        '
        'btnsearch
        '
        Me.btnsearch.AutoSize = True
        Me.btnsearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnsearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnsearch.Location = New System.Drawing.Point(424, 3)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(115, 41)
        Me.btnsearch.TabIndex = 93
        Me.btnsearch.Text = "btnsearch"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'DGVaccountlogs
        '
        Me.DGVaccountlogs.AllowUserToAddRows = False
        Me.DGVaccountlogs.AllowUserToDeleteRows = False
        Me.DGVaccountlogs.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVaccountlogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGVaccountlogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVaccountlogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.username, Me.datein, Me.timein, Me.dateout, Me.timeout})
        Me.DGVaccountlogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVaccountlogs.GridColor = System.Drawing.SystemColors.HotTrack
        Me.DGVaccountlogs.Location = New System.Drawing.Point(3, 56)
        Me.DGVaccountlogs.Name = "DGVaccountlogs"
        Me.DGVaccountlogs.ReadOnly = True
        Me.DGVaccountlogs.Size = New System.Drawing.Size(582, 245)
        Me.DGVaccountlogs.TabIndex = 88
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
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnback, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 307)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(582, 42)
        Me.TableLayoutPanel4.TabIndex = 89
        '
        'btnback
        '
        Me.btnback.AutoSize = True
        Me.btnback.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnback.Location = New System.Drawing.Point(197, 3)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(188, 36)
        Me.btnback.TabIndex = 93
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.39535!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.60465!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(588, 75)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(150, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Account Logs"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'accountlogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Login.My.Resources.Resources._467460386_1064088022134846_6079649981189841706_n
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(594, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "accountlogs"
        Me.Text = "accountlogs"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.DGVaccountlogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents cbosearch As ComboBox
    Friend WithEvents txtsearchbox As TextBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents DGVaccountlogs As DataGridView
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents datein As DataGridViewTextBoxColumn
    Friend WithEvents timein As DataGridViewTextBoxColumn
    Friend WithEvents dateout As DataGridViewTextBoxColumn
    Friend WithEvents timeout As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnback As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label1 As Label
End Class
