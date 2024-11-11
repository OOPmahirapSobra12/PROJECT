<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewFeedbackReport
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
        Me.txttime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttype = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsender = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        Me.DGVtextbox = New System.Windows.Forms.DataGridView()
        Me.sendertext = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVtextbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txttime
        '
        Me.txttime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttime.Location = New System.Drawing.Point(550, 263)
        Me.txttime.Name = "txttime"
        Me.txttime.ReadOnly = True
        Me.txttime.Size = New System.Drawing.Size(104, 29)
        Me.txttime.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(491, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 24)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Time:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtdate
        '
        Me.txtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.Location = New System.Drawing.Point(550, 228)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.ReadOnly = True
        Me.txtdate.Size = New System.Drawing.Size(104, 29)
        Me.txtdate.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(491, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 24)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Date:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txttype
        '
        Me.txttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttype.Location = New System.Drawing.Point(550, 193)
        Me.txttype.Name = "txttype"
        Me.txttype.ReadOnly = True
        Me.txttype.Size = New System.Drawing.Size(104, 29)
        Me.txttype.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(486, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 24)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Type:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtsender
        '
        Me.txtsender.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsender.Location = New System.Drawing.Point(550, 158)
        Me.txtsender.Name = "txtsender"
        Me.txtsender.ReadOnly = True
        Me.txtsender.Size = New System.Drawing.Size(200, 29)
        Me.txtsender.TabIndex = 57
        '
        'txtcode
        '
        Me.txtcode.AutoSize = True
        Me.txtcode.BackColor = System.Drawing.Color.Transparent
        Me.txtcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.ForeColor = System.Drawing.Color.NavajoWhite
        Me.txtcode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtcode.Location = New System.Drawing.Point(467, 160)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(77, 24)
        Me.txtcode.TabIndex = 58
        Me.txtcode.Text = "Sender:"
        Me.txtcode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnback
        '
        Me.btnback.AutoSize = True
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnback.Location = New System.Drawing.Point(471, 313)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(73, 43)
        Me.btnback.TabIndex = 56
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'DGVtextbox
        '
        Me.DGVtextbox.AllowUserToAddRows = False
        Me.DGVtextbox.AllowUserToDeleteRows = False
        Me.DGVtextbox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVtextbox.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVtextbox.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.DGVtextbox.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DGVtextbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVtextbox.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sendertext})
        Me.DGVtextbox.Location = New System.Drawing.Point(50, 131)
        Me.DGVtextbox.MultiSelect = False
        Me.DGVtextbox.Name = "DGVtextbox"
        Me.DGVtextbox.ReadOnly = True
        Me.DGVtextbox.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGVtextbox.Size = New System.Drawing.Size(414, 225)
        Me.DGVtextbox.TabIndex = 55
        '
        'sendertext
        '
        Me.sendertext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.sendertext.HeaderText = "Text"
        Me.sendertext.Name = "sendertext"
        Me.sendertext.ReadOnly = True
        '
        'ViewFeedbackReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Login.My.Resources.Resources.FB_IMG_1729211691620
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txttime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttype)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsender)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.DGVtextbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ViewFeedbackReport"
        Me.Text = "ViewFeedbackReport"
        CType(Me.DGVtextbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txttime As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txttype As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtsender As TextBox
    Friend WithEvents txtcode As Label
    Friend WithEvents btnback As Button
    Friend WithEvents DGVtextbox As DataGridView
    Friend WithEvents sendertext As DataGridViewTextBoxColumn
End Class
