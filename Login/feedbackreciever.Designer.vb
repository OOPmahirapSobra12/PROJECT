<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class feedbackreciever
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
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearchbox = New System.Windows.Forms.TextBox()
        Me.cbosearch = New System.Windows.Forms.ComboBox()
        Me.DGVfeedback = New System.Windows.Forms.DataGridView()
        Me.FeedbackID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeedbackDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeedbackTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeedbackView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.FeedbackDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DGVfeedback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnback
        '
        Me.btnback.AutoSize = True
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnback.Location = New System.Drawing.Point(257, 415)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(73, 35)
        Me.btnback.TabIndex = 90
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.AutoSize = True
        Me.btnsearch.BackColor = System.Drawing.Color.Transparent
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnsearch.Location = New System.Drawing.Point(453, 125)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(124, 35)
        Me.btnsearch.TabIndex = 87
        Me.btnsearch.Text = "btnsearch"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'txtsearchbox
        '
        Me.txtsearchbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.txtsearchbox.Location = New System.Drawing.Point(208, 125)
        Me.txtsearchbox.Name = "txtsearchbox"
        Me.txtsearchbox.Size = New System.Drawing.Size(239, 31)
        Me.txtsearchbox.TabIndex = 88
        '
        'cbosearch
        '
        Me.cbosearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cbosearch.FormattingEnabled = True
        Me.cbosearch.Items.AddRange(New Object() {"Choose:", "Date", "Time"})
        Me.cbosearch.Location = New System.Drawing.Point(69, 123)
        Me.cbosearch.Name = "cbosearch"
        Me.cbosearch.Size = New System.Drawing.Size(133, 33)
        Me.cbosearch.TabIndex = 89
        '
        'DGVfeedback
        '
        Me.DGVfeedback.AllowUserToAddRows = False
        Me.DGVfeedback.AllowUserToDeleteRows = False
        Me.DGVfeedback.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.DGVfeedback.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGVfeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVfeedback.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FeedbackID, Me.FeedbackDate, Me.FeedbackTime, Me.FeedbackView, Me.FeedbackDelete})
        Me.DGVfeedback.GridColor = System.Drawing.Color.NavajoWhite
        Me.DGVfeedback.Location = New System.Drawing.Point(12, 161)
        Me.DGVfeedback.Name = "DGVfeedback"
        Me.DGVfeedback.ReadOnly = True
        Me.DGVfeedback.Size = New System.Drawing.Size(570, 254)
        Me.DGVfeedback.TabIndex = 86
        '
        'FeedbackID
        '
        Me.FeedbackID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FeedbackID.HeaderText = "Feedback ID"
        Me.FeedbackID.Name = "FeedbackID"
        Me.FeedbackID.ReadOnly = True
        '
        'FeedbackDate
        '
        Me.FeedbackDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FeedbackDate.HeaderText = "Feedback Date"
        Me.FeedbackDate.Name = "FeedbackDate"
        Me.FeedbackDate.ReadOnly = True
        '
        'FeedbackTime
        '
        Me.FeedbackTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FeedbackTime.HeaderText = "Feedback Time"
        Me.FeedbackTime.Name = "FeedbackTime"
        Me.FeedbackTime.ReadOnly = True
        '
        'FeedbackView
        '
        Me.FeedbackView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FeedbackView.HeaderText = "View"
        Me.FeedbackView.Name = "FeedbackView"
        Me.FeedbackView.ReadOnly = True
        '
        'FeedbackDelete
        '
        Me.FeedbackDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FeedbackDelete.HeaderText = "Delete"
        Me.FeedbackDelete.Name = "FeedbackDelete"
        Me.FeedbackDelete.ReadOnly = True
        '
        'feedbackreciever
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
        Me.Controls.Add(Me.DGVfeedback)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "feedbackreciever"
        Me.Text = "feedbackreciever"
        CType(Me.DGVfeedback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnback As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtsearchbox As TextBox
    Friend WithEvents cbosearch As ComboBox
    Friend WithEvents DGVfeedback As DataGridView
    Friend WithEvents FeedbackID As DataGridViewTextBoxColumn
    Friend WithEvents FeedbackDate As DataGridViewTextBoxColumn
    Friend WithEvents FeedbackTime As DataGridViewTextBoxColumn
    Friend WithEvents FeedbackView As DataGridViewButtonColumn
    Friend WithEvents FeedbackDelete As DataGridViewButtonColumn
End Class
