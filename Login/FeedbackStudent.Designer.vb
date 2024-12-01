<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class feedbackstudent
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
        Me.txttitle = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtmessage = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblWHAT = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.cbotype = New System.Windows.Forms.ComboBox()
        Me.cboWHAT = New System.Windows.Forms.ComboBox()
        Me.btnselect = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnsend = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.38021!))
        Me.TableLayoutPanel1.Controls.Add(Me.txttitle, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.01512!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.98488!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(839, 463)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'txttitle
        '
        Me.txttitle.AutoSize = True
        Me.txttitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txttitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttitle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txttitle.Location = New System.Drawing.Point(3, 0)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(833, 51)
        Me.txttitle.TabIndex = 99
        Me.txttitle.Text = "Report and Feedback Center"
        Me.txttitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.89108!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 54)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.73219!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.26781!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(833, 406)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.89108!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtmessage, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.9711!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.0289!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(827, 346)
        Me.TableLayoutPanel3.TabIndex = 14
        '
        'txtmessage
        '
        Me.txtmessage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtmessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtmessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.txtmessage.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtmessage.Location = New System.Drawing.Point(3, 124)
        Me.txtmessage.Multiline = True
        Me.txtmessage.Name = "txtmessage"
        Me.txtmessage.ReadOnly = True
        Me.txtmessage.Size = New System.Drawing.Size(821, 219)
        Me.txtmessage.TabIndex = 108
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.72659!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.8427!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.83521!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.84519!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.lblWHAT, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtuser, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cbotype, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.cboWHAT, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnselect, 4, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(821, 115)
        Me.TableLayoutPanel4.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(23, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 38)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Sender:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(23, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 38)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Type:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(23, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 39)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Message:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblWHAT
        '
        Me.lblWHAT.AutoSize = True
        Me.lblWHAT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWHAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWHAT.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblWHAT.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblWHAT.Location = New System.Drawing.Point(378, 0)
        Me.lblWHAT.Name = "lblWHAT"
        Me.lblWHAT.Size = New System.Drawing.Size(248, 38)
        Me.lblWHAT.TabIndex = 105
        Me.lblWHAT.Text = "What to report?"
        Me.lblWHAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWHAT.Visible = False
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtuser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.txtuser.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtuser.Location = New System.Drawing.Point(172, 3)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.ReadOnly = True
        Me.txtuser.Size = New System.Drawing.Size(200, 31)
        Me.txtuser.TabIndex = 106
        '
        'cbotype
        '
        Me.cbotype.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbotype.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbotype.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cbotype.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbotype.FormattingEnabled = True
        Me.cbotype.Items.AddRange(New Object() {"Choose:", "Report", "Feedback"})
        Me.cbotype.Location = New System.Drawing.Point(172, 41)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.Size = New System.Drawing.Size(200, 33)
        Me.cbotype.TabIndex = 112
        '
        'cboWHAT
        '
        Me.cboWHAT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cboWHAT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboWHAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cboWHAT.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboWHAT.FormattingEnabled = True
        Me.cboWHAT.Items.AddRange(New Object() {"Choose:", "Room", "Data", "System"})
        Me.cboWHAT.Location = New System.Drawing.Point(632, 3)
        Me.cboWHAT.Name = "cboWHAT"
        Me.cboWHAT.Size = New System.Drawing.Size(186, 33)
        Me.cboWHAT.TabIndex = 113
        Me.cboWHAT.Visible = False
        '
        'btnselect
        '
        Me.btnselect.AutoSize = True
        Me.btnselect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnselect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnselect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselect.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnselect.Location = New System.Drawing.Point(632, 41)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(186, 32)
        Me.btnselect.TabIndex = 114
        Me.btnselect.Text = "Select Room"
        Me.btnselect.UseVisualStyleBackColor = False
        Me.btnselect.Visible = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnsend, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnclear, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnback, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 355)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(827, 48)
        Me.TableLayoutPanel5.TabIndex = 15
        '
        'btnsend
        '
        Me.btnsend.AutoSize = True
        Me.btnsend.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnsend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnsend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsend.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsend.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnsend.Location = New System.Drawing.Point(553, 3)
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Size = New System.Drawing.Size(271, 42)
        Me.btnsend.TabIndex = 102
        Me.btnsend.Text = "Send"
        Me.btnsend.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.AutoSize = True
        Me.btnclear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnclear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnclear.Location = New System.Drawing.Point(278, 3)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(269, 42)
        Me.btnclear.TabIndex = 101
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnback
        '
        Me.btnback.AutoSize = True
        Me.btnback.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnback.Location = New System.Drawing.Point(3, 3)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(269, 42)
        Me.btnback.TabIndex = 100
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'feedbackstudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Login.My.Resources.Resources._467460386_1064088022134846_6079649981189841706_n
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(839, 463)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "feedbackstudent"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Feedback Form Student"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txttitle As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents txtmessage As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblWHAT As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents cbotype As ComboBox
    Friend WithEvents cboWHAT As ComboBox
    Friend WithEvents btnselect As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents btnsend As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnback As Button
End Class
