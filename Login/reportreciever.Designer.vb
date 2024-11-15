<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportreciever
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
        Me.DGVreport = New System.Windows.Forms.DataGridView()
        Me.ReportID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ReportDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearchbox = New System.Windows.Forms.TextBox()
        Me.cbosearch = New System.Windows.Forms.ComboBox()
        Me.btnback = New System.Windows.Forms.Button()
        CType(Me.DGVreport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVreport
        '
        Me.DGVreport.AllowUserToAddRows = False
        Me.DGVreport.AllowUserToDeleteRows = False
        Me.DGVreport.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.DGVreport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGVreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVreport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReportID, Me.ReportDate, Me.ReportTime, Me.ReportView, Me.ReportDelete})
        Me.DGVreport.GridColor = System.Drawing.Color.NavajoWhite
        Me.DGVreport.Location = New System.Drawing.Point(12, 163)
        Me.DGVreport.Name = "DGVreport"
        Me.DGVreport.ReadOnly = True
        Me.DGVreport.Size = New System.Drawing.Size(570, 245)
        Me.DGVreport.TabIndex = 5
        '
        'ReportID
        '
        Me.ReportID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReportID.HeaderText = "Report ID"
        Me.ReportID.Name = "ReportID"
        Me.ReportID.ReadOnly = True
        '
        'ReportDate
        '
        Me.ReportDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReportDate.HeaderText = "Date Reported"
        Me.ReportDate.Name = "ReportDate"
        Me.ReportDate.ReadOnly = True
        '
        'ReportTime
        '
        Me.ReportTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReportTime.HeaderText = "Time Reported"
        Me.ReportTime.Name = "ReportTime"
        Me.ReportTime.ReadOnly = True
        '
        'ReportView
        '
        Me.ReportView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReportView.HeaderText = "View"
        Me.ReportView.Name = "ReportView"
        Me.ReportView.ReadOnly = True
        '
        'ReportDelete
        '
        Me.ReportDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReportDelete.HeaderText = "Delete"
        Me.ReportDelete.Name = "ReportDelete"
        Me.ReportDelete.ReadOnly = True
        '
        'btnsearch
        '
        Me.btnsearch.AutoSize = True
        Me.btnsearch.BackColor = System.Drawing.Color.Transparent
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnsearch.Location = New System.Drawing.Point(454, 126)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(124, 35)
        Me.btnsearch.TabIndex = 12
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'txtsearchbox
        '
        Me.txtsearchbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.txtsearchbox.Location = New System.Drawing.Point(209, 126)
        Me.txtsearchbox.Name = "txtsearchbox"
        Me.txtsearchbox.Size = New System.Drawing.Size(239, 31)
        Me.txtsearchbox.TabIndex = 13
        '
        'cbosearch
        '
        Me.cbosearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cbosearch.FormattingEnabled = True
        Me.cbosearch.Items.AddRange(New Object() {"Choose:", "Date", "Time"})
        Me.cbosearch.Location = New System.Drawing.Point(70, 124)
        Me.cbosearch.Name = "cbosearch"
        Me.cbosearch.Size = New System.Drawing.Size(133, 33)
        Me.cbosearch.TabIndex = 14
        '
        'btnback
        '
        Me.btnback.AutoSize = True
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnback.Location = New System.Drawing.Point(260, 414)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(73, 35)
        Me.btnback.TabIndex = 86
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'reportreciever
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
        Me.Controls.Add(Me.DGVreport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reportreciever"
        Me.Text = "reportreciever"
        CType(Me.DGVreport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVreport As DataGridView
    Friend WithEvents ReportID As DataGridViewTextBoxColumn
    Friend WithEvents ReportDate As DataGridViewTextBoxColumn
    Friend WithEvents ReportTime As DataGridViewTextBoxColumn
    Friend WithEvents ReportView As DataGridViewButtonColumn
    Friend WithEvents ReportDelete As DataGridViewButtonColumn
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtsearchbox As TextBox
    Friend WithEvents cbosearch As ComboBox
    Friend WithEvents btnback As Button
End Class
