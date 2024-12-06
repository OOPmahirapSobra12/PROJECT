<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class crystalreportviewer
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Roomlistreport1 = New Login.Roomlistreport()
        Me.CourseSectionReport1 = New Login.CourseSectionReport()
        Me.AdminListReport1 = New Login.AdminListReport()
        Me.StaffListReport1 = New Login.StaffListReport()
        Me.StudentListReport1 = New Login.StudentListReport()
        Me.AcceptedRequestReport1 = New Login.AcceptedRequestReport()
        Me.CurrentRequests1 = New Login.CurrentRequests()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CurrentRequests1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'crystalreportviewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "crystalreportviewer"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CourseSectionReport1 As Login.CourseSectionReport
    Friend WithEvents Roomlistreport1 As Login.Roomlistreport
    Friend WithEvents AdminListReport1 As Login.AdminListReport
    Friend WithEvents StudentListReport1 As Login.StudentListReport
    Friend WithEvents StaffListReport1 As Login.StaffListReport
    Friend WithEvents CurrentRequests1 As Login.CurrentRequests
    Friend WithEvents AcceptedRequestReport1 As Login.AcceptedRequestReport
End Class
