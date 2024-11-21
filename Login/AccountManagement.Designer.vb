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
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.cbosearch = New System.Windows.Forms.ComboBox()
        Me.txtsearchbox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnback = New System.Windows.Forms.Button()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PBpic = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.buttonpic = New System.Windows.Forms.Button()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbolevel = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DGVaccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.PBpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
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
        Me.TableLayoutPanel4.Controls.Add(Me.btnsearch, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cbosearch, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtsearchbox, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(23, 76)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(467, 40)
        Me.TableLayoutPanel4.TabIndex = 100
        '
        'btnsearch
        '
        Me.btnsearch.AutoSize = True
        Me.btnsearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnsearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnsearch.Location = New System.Drawing.Point(313, 3)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(151, 34)
        Me.btnsearch.TabIndex = 96
        Me.btnsearch.Text = "btnsearch"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'cbosearch
        '
        Me.cbosearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbosearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbosearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cbosearch.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbosearch.FormattingEnabled = True
        Me.cbosearch.Items.AddRange(New Object() {"Choose:", "Account ID", "Username", "Access Level"})
        Me.cbosearch.Location = New System.Drawing.Point(3, 3)
        Me.cbosearch.Name = "cbosearch"
        Me.cbosearch.Size = New System.Drawing.Size(149, 33)
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
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel8, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(502, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.26126!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.73874!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(295, 444)
        Me.TableLayoutPanel6.TabIndex = 2
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.PBpic, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel9, 1, 1)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.83333!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.16666!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(281, 154)
        Me.TableLayoutPanel8.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 32)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Account Pic:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'PBpic
        '
        Me.PBpic.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PBpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBpic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBpic.Location = New System.Drawing.Point(3, 35)
        Me.PBpic.Name = "PBpic"
        Me.PBpic.Size = New System.Drawing.Size(134, 116)
        Me.PBpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBpic.TabIndex = 100
        Me.PBpic.TabStop = False
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.33334!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66667!))
        Me.TableLayoutPanel9.Controls.Add(Me.buttonpic, 0, 1)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(143, 35)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 2
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.68965!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.31034!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(135, 116)
        Me.TableLayoutPanel9.TabIndex = 101
        '
        'buttonpic
        '
        Me.buttonpic.AutoSize = True
        Me.buttonpic.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.buttonpic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonpic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonpic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonpic.ForeColor = System.Drawing.Color.MidnightBlue
        Me.buttonpic.Location = New System.Drawing.Point(3, 85)
        Me.buttonpic.Name = "buttonpic"
        Me.buttonpic.Size = New System.Drawing.Size(92, 28)
        Me.buttonpic.TabIndex = 101
        Me.buttonpic.Text = "Update Pic:"
        Me.buttonpic.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.04271!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.95729!))
        Me.TableLayoutPanel7.Controls.Add(Me.txtID, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.txtfname, 1, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.txtlname, 1, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.txtusername, 1, 3)
        Me.TableLayoutPanel7.Controls.Add(Me.txtcode, 0, 3)
        Me.TableLayoutPanel7.Controls.Add(Me.txtpassword, 1, 4)
        Me.TableLayoutPanel7.Controls.Add(Me.Label2, 0, 4)
        Me.TableLayoutPanel7.Controls.Add(Me.cbolevel, 1, 5)
        Me.TableLayoutPanel7.Controls.Add(Me.Label7, 0, 5)
        Me.TableLayoutPanel7.Controls.Add(Me.btnclear, 1, 6)
        Me.TableLayoutPanel7.Controls.Add(Me.btnupdate, 0, 6)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 163)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 8
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.38849!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.23022!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(281, 278)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtID.Location = New System.Drawing.Point(138, 3)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(140, 29)
        Me.txtID.TabIndex = 105
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 34)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Account ID:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtfname
        '
        Me.txtfname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtfname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtfname.Location = New System.Drawing.Point(138, 37)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(140, 29)
        Me.txtfname.TabIndex = 107
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Location = New System.Drawing.Point(3, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 34)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "First Name:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtlname
        '
        Me.txtlname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtlname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtlname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtlname.Location = New System.Drawing.Point(138, 71)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(140, 29)
        Me.txtlname.TabIndex = 109
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(3, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 34)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Last Name:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtusername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtusername.Location = New System.Drawing.Point(138, 105)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(140, 29)
        Me.txtusername.TabIndex = 111
        '
        'txtcode
        '
        Me.txtcode.AutoSize = True
        Me.txtcode.BackColor = System.Drawing.Color.Transparent
        Me.txtcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtcode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtcode.Location = New System.Drawing.Point(3, 102)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(129, 34)
        Me.txtcode.TabIndex = 112
        Me.txtcode.Text = "Username:"
        Me.txtcode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtpassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtpassword.Location = New System.Drawing.Point(138, 139)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(140, 29)
        Me.txtpassword.TabIndex = 114
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(3, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 34)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Password:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbolevel
        '
        Me.cbolevel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbolevel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbolevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cbolevel.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbolevel.FormattingEnabled = True
        Me.cbolevel.Items.AddRange(New Object() {"Admin", "Teacher", "Student"})
        Me.cbolevel.Location = New System.Drawing.Point(138, 173)
        Me.cbolevel.Name = "cbolevel"
        Me.cbolevel.Size = New System.Drawing.Size(140, 32)
        Me.cbolevel.TabIndex = 116
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(3, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 34)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Access Level:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnclear
        '
        Me.btnclear.AutoSize = True
        Me.btnclear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnclear.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnclear.Location = New System.Drawing.Point(205, 207)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(73, 33)
        Me.btnclear.TabIndex = 117
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.AutoSize = True
        Me.btnupdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnupdate.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnupdate.Enabled = False
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnupdate.Location = New System.Drawing.Point(3, 207)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(91, 33)
        Me.btnupdate.TabIndex = 118
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
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
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        CType(Me.PBpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
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
    Friend WithEvents Label3 As Label
    Friend WithEvents PBpic As PictureBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents buttonpic As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtlname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtcode As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbolevel As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents btnupdate As Button
End Class
