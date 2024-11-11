<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addscheduleadmin
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearchbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbosearch = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtrname = New System.Windows.Forms.TextBox()
        Me.txtrcode = New System.Windows.Forms.TextBox()
        Me.txtrDD = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.Label()
        Me.txtroom = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboDD = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbuilding = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbominute = New System.Windows.Forms.ComboBox()
        Me.cboampm = New System.Windows.Forms.ComboBox()
        Me.cbohour = New System.Windows.Forms.ComboBox()
        Me.DGVrooms = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnaddschedule = New System.Windows.Forms.Button()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.DGVrooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.04038!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.50832!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.45131!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1200, 692)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.DGVrooms, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(34, 185)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.60777!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.71533!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.86131!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1132, 421)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.41711!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.58289!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.8877!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.1123!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnsearch, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtsearchbox, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cbosearch, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, 5)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1124, 59)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'btnsearch
        '
        Me.btnsearch.AutoSize = True
        Me.btnsearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnsearch.Location = New System.Drawing.Point(934, 5)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(186, 49)
        Me.btnsearch.TabIndex = 0
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtsearchbox
        '
        Me.txtsearchbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtsearchbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.txtsearchbox.Location = New System.Drawing.Point(565, 5)
        Me.txtsearchbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsearchbox.Name = "txtsearchbox"
        Me.txtsearchbox.Size = New System.Drawing.Size(361, 43)
        Me.txtsearchbox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 59)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search Box:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbosearch
        '
        Me.cbosearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbosearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cbosearch.FormattingEnabled = True
        Me.cbosearch.Location = New System.Drawing.Point(357, 5)
        Me.cbosearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbosearch.Name = "cbosearch"
        Me.cbosearch.Size = New System.Drawing.Size(200, 45)
        Me.cbosearch.TabIndex = 3
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.25134!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.54011!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.63102!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.79679!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.55664!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnadd, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtrname, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtrcode, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtrDD, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtcode, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtroom, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.cboDD, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label8, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtbuilding, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 3, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(4, 270)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.41667!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.29167!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1124, 146)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'btnadd
        '
        Me.btnadd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnadd.Location = New System.Drawing.Point(1008, 5)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(112, 42)
        Me.btnadd.TabIndex = 2
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtrname
        '
        Me.txtrname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtrname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrname.Location = New System.Drawing.Point(220, 5)
        Me.txtrname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtrname.Name = "txtrname"
        Me.txtrname.Size = New System.Drawing.Size(302, 40)
        Me.txtrname.TabIndex = 0
        '
        'txtrcode
        '
        Me.txtrcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtrcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrcode.Location = New System.Drawing.Point(220, 57)
        Me.txtrcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtrcode.Name = "txtrcode"
        Me.txtrcode.Size = New System.Drawing.Size(302, 40)
        Me.txtrcode.TabIndex = 1
        '
        'txtrDD
        '
        Me.txtrDD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtrDD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrDD.Location = New System.Drawing.Point(661, 5)
        Me.txtrDD.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtrDD.Name = "txtrDD"
        Me.txtrDD.Size = New System.Drawing.Size(260, 40)
        Me.txtrDD.TabIndex = 4
        '
        'txtcode
        '
        Me.txtcode.AutoSize = True
        Me.txtcode.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.ForeColor = System.Drawing.Color.NavajoWhite
        Me.txtcode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtcode.Location = New System.Drawing.Point(25, 0)
        Me.txtcode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(187, 52)
        Me.txtcode.TabIndex = 8
        Me.txtcode.Text = "Room Name:"
        Me.txtcode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtroom
        '
        Me.txtroom.AutoSize = True
        Me.txtroom.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtroom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtroom.ForeColor = System.Drawing.Color.NavajoWhite
        Me.txtroom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtroom.Location = New System.Drawing.Point(34, 52)
        Me.txtroom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtroom.Name = "txtroom"
        Me.txtroom.Size = New System.Drawing.Size(178, 47)
        Me.txtroom.TabIndex = 9
        Me.txtroom.Text = "Room Code:"
        Me.txtroom.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(93, 99)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 47)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Building Letter:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cboDD
        '
        Me.cboDD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboDD.FormattingEnabled = True
        Me.cboDD.Location = New System.Drawing.Point(530, 5)
        Me.cboDD.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboDD.Name = "cboDD"
        Me.cboDD.Size = New System.Drawing.Size(123, 28)
        Me.cboDD.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(564, 52)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 47)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Time:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtbuilding
        '
        Me.txtbuilding.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbuilding.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuilding.Location = New System.Drawing.Point(220, 104)
        Me.txtbuilding.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbuilding.Name = "txtbuilding"
        Me.txtbuilding.Size = New System.Drawing.Size(302, 40)
        Me.txtbuilding.TabIndex = 2
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.Controls.Add(Me.cbominute, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.cboampm, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.cbohour, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(661, 57)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(258, 37)
        Me.TableLayoutPanel6.TabIndex = 16
        '
        'cbominute
        '
        Me.cbominute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbominute.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbominute.FormattingEnabled = True
        Me.cbominute.Location = New System.Drawing.Point(90, 5)
        Me.cbominute.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbominute.Name = "cbominute"
        Me.cbominute.Size = New System.Drawing.Size(78, 28)
        Me.cbominute.TabIndex = 1
        '
        'cboampm
        '
        Me.cboampm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboampm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboampm.FormattingEnabled = True
        Me.cboampm.Location = New System.Drawing.Point(176, 5)
        Me.cboampm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboampm.Name = "cboampm"
        Me.cboampm.Size = New System.Drawing.Size(78, 28)
        Me.cboampm.TabIndex = 2
        '
        'cbohour
        '
        Me.cbohour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbohour.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbohour.FormattingEnabled = True
        Me.cbohour.Location = New System.Drawing.Point(4, 5)
        Me.cbohour.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbohour.Name = "cbohour"
        Me.cbohour.Size = New System.Drawing.Size(78, 28)
        Me.cbohour.TabIndex = 17
        '
        'DGVrooms
        '
        Me.DGVrooms.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.DGVrooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVrooms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVrooms.Location = New System.Drawing.Point(4, 74)
        Me.DGVrooms.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGVrooms.Name = "DGVrooms"
        Me.DGVrooms.RowHeadersWidth = 62
        Me.DGVrooms.Size = New System.Drawing.Size(1124, 186)
        Me.DGVrooms.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnback, 3, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnclear, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnaddschedule, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnconfirm, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(34, 616)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1132, 57)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'btnback
        '
        Me.btnback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnback.Location = New System.Drawing.Point(853, 5)
        Me.btnback.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(275, 47)
        Me.btnback.TabIndex = 0
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnclear.Location = New System.Drawing.Point(570, 5)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(275, 47)
        Me.btnclear.TabIndex = 1
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnaddschedule
        '
        Me.btnaddschedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnaddschedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnaddschedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddschedule.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnaddschedule.Location = New System.Drawing.Point(287, 5)
        Me.btnaddschedule.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnaddschedule.Name = "btnaddschedule"
        Me.btnaddschedule.Size = New System.Drawing.Size(275, 47)
        Me.btnaddschedule.TabIndex = 2
        Me.btnaddschedule.Text = "Add Schedule"
        Me.btnaddschedule.UseVisualStyleBackColor = True
        '
        'btnconfirm
        '
        Me.btnconfirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirm.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnconfirm.Location = New System.Drawing.Point(4, 5)
        Me.btnconfirm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(275, 47)
        Me.btnconfirm.TabIndex = 15
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = True
        '
        'addscheduleadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Login.My.Resources.Resources.FB_IMG_1729211691620
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "addscheduleadmin"
        Me.Text = "addscheduleadmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        CType(Me.DGVrooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtsearchbox As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents txtrname As TextBox
    Friend WithEvents txtrcode As TextBox
    Friend WithEvents txtbuilding As TextBox
    Friend WithEvents txtrDD As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcode As Label
    Friend WithEvents txtroom As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents btnback As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnaddschedule As Button
    Friend WithEvents cbosearch As ComboBox
    Friend WithEvents DGVrooms As DataGridView
    Friend WithEvents btnadd As Button
    Friend WithEvents btnconfirm As Button
    Friend WithEvents cboDD As ComboBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents cbominute As ComboBox
    Friend WithEvents cboampm As ComboBox
    Friend WithEvents cbohour As ComboBox
End Class
