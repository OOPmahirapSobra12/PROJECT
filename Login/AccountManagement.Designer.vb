<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccountManagement
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVaccounts = New System.Windows.Forms.DataGridView()
        Me.accountID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accesslevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnmodify = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbosearch = New System.Windows.Forms.ComboBox()
        Me.txtsearchbox = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnback = New System.Windows.Forms.Button()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DGVaccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.375!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.625!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.DGVaccounts, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 1, 5)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.71322!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.95238!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.71429!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.18408!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.47382!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(493, 444)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(23, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(467, 62)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Account Logs"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DGVaccounts
        '
        Me.DGVaccounts.AllowUserToAddRows = False
        Me.DGVaccounts.AllowUserToDeleteRows = False
        Me.DGVaccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVaccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVaccounts.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVaccounts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DGVaccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVaccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.accountID, Me.username, Me.Accesslevel})
        Me.DGVaccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVaccounts.GridColor = System.Drawing.Color.MidnightBlue
        Me.DGVaccounts.Location = New System.Drawing.Point(23, 122)
        Me.DGVaccounts.MultiSelect = False
        Me.DGVaccounts.Name = "DGVaccounts"
        Me.DGVaccounts.ReadOnly = True
        Me.DGVaccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGVaccounts.Size = New System.Drawing.Size(467, 207)
        Me.DGVaccounts.TabIndex = 98
        '
        'accountID
        '
        Me.accountID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.accountID.HeaderText = "Account ID"
        Me.accountID.Name = "accountID"
        Me.accountID.ReadOnly = True
        '
        'username
        '
        Me.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        '
        'Accesslevel
        '
        Me.Accesslevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Accesslevel.HeaderText = "Access Level"
        Me.Accesslevel.Name = "Accesslevel"
        Me.Accesslevel.ReadOnly = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btndelete, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnmodify, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnadd, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(23, 335)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(467, 49)
        Me.TableLayoutPanel3.TabIndex = 99
        '
        'btndelete
        '
        Me.btndelete.AutoSize = True
        Me.btndelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btndelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btndelete.Location = New System.Drawing.Point(3, 3)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(110, 43)
        Me.btndelete.TabIndex = 96
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnmodify
        '
        Me.btnmodify.AutoSize = True
        Me.btnmodify.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnmodify.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnmodify.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmodify.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnmodify.Location = New System.Drawing.Point(351, 3)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(113, 43)
        Me.btnmodify.TabIndex = 97
        Me.btnmodify.Text = "Modify"
        Me.btnmodify.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.AutoSize = True
        Me.btnadd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnadd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnadd.Location = New System.Drawing.Point(235, 3)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(110, 43)
        Me.btnadd.TabIndex = 98
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.cbosearch, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtsearchbox, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnsearch, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(23, 76)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(467, 40)
        Me.TableLayoutPanel4.TabIndex = 100
        '
        'cbosearch
        '
        Me.cbosearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbosearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbosearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cbosearch.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbosearch.FormattingEnabled = True
        Me.cbosearch.Items.AddRange(New Object() {"Choose:", "Username", "Date In", "Date Out", "Time In", "Time Out"})
        Me.cbosearch.Location = New System.Drawing.Point(313, 3)
        Me.cbosearch.Name = "cbosearch"
        Me.cbosearch.Size = New System.Drawing.Size(151, 33)
        Me.cbosearch.TabIndex = 94
        '
        'txtsearchbox
        '
        Me.txtsearchbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtsearchbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtsearchbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.txtsearchbox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtsearchbox.Location = New System.Drawing.Point(158, 3)
        Me.txtsearchbox.Name = "txtsearchbox"
        Me.txtsearchbox.Size = New System.Drawing.Size(149, 31)
        Me.txtsearchbox.TabIndex = 95
        '
        'btnsearch
        '
        Me.btnsearch.AutoSize = True
        Me.btnsearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnsearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnsearch.Location = New System.Drawing.Point(3, 3)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(149, 34)
        Me.btnsearch.TabIndex = 96
        Me.btnsearch.Text = "btnsearch"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnback, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(23, 390)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(467, 38)
        Me.TableLayoutPanel5.TabIndex = 101
        '
        'btnback
        '
        Me.btnback.AutoSize = True
        Me.btnback.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnback.Location = New System.Drawing.Point(158, 3)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(149, 32)
        Me.btnback.TabIndex = 99
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(502, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(295, 444)
        Me.TableLayoutPanel6.TabIndex = 2
        '
        'AccountManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Login.My.Resources.Resources._467460386_1064088022134846_6079649981189841706_n
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccountManagement"
        Me.Text = "AccountManagement"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.DGVaccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents DGVaccounts As DataGridView
    Friend WithEvents accountID As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents Accesslevel As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents btndelete As Button
    Friend WithEvents btnmodify As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnback As Button
    Friend WithEvents cbosearch As ComboBox
    Friend WithEvents txtsearchbox As TextBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents Label1 As Label
End Class
