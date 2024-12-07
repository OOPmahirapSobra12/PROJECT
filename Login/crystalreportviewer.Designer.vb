<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crystalreportviewer
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.AcceptedRequestReport1 = New Login.AcceptedRequestReport()
        Me.AdminListReport1 = New Login.AdminListReport()
        Me.CourseSectionReport1 = New Login.CourseSectionReport()
        Me.CurrentRequests1 = New Login.CurrentRequests()
        Me.DeniedRequestForm1 = New Login.DeniedRequestForm()
        Me.feedbackshistory1 = New Login.feedbackshistory()
        Me.reportshistory1 = New Login.reportshistory()
        Me.Roomlistreport1 = New Login.Roomlistreport()
        Me.roomloginhistory1 = New Login.roomloginhistory()
        Me.ScheduleListReport1 = New Login.ScheduleListReport()
        Me.StaffAccessingAdminControlLogs1 = New Login.StaffAccessingAdminControlLogs()
        Me.StaffListReport1 = New Login.StaffListReport()
        Me.StudentListReport1 = New Login.StudentListReport()
        Me.subjectlist1 = New Login.subjectlist()
        Me.System_LogsReport1 = New Login.System_LogsReport()
        Me.TemporaryScheduleListReport1 = New Login.TemporaryScheduleListReport()
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
        Me.CrystalReportViewer1.ReportSource = Me.AcceptedRequestReport1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1040, 558)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'crystalreportviewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Login.My.Resources.Resources.FB_IMG_1729211691620
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1040, 558)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "crystalreportviewer"
        Me.Text = "crystalreportviewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents AcceptedRequestReport1 As Login.AcceptedRequestReport
    Friend WithEvents AdminListReport1 As Login.AdminListReport
    Friend WithEvents CourseSectionReport1 As Login.CourseSectionReport
    Friend WithEvents CurrentRequests1 As Login.CurrentRequests
    Friend WithEvents DeniedRequestForm1 As Login.DeniedRequestForm
    Friend WithEvents feedbackshistory1 As Login.feedbackshistory
    Friend WithEvents reportshistory1 As Login.reportshistory
    Friend WithEvents Roomlistreport1 As Login.Roomlistreport
    Friend WithEvents roomloginhistory1 As Login.roomloginhistory
    Friend WithEvents ScheduleListReport1 As Login.ScheduleListReport
    Friend WithEvents StaffAccessingAdminControlLogs1 As Login.StaffAccessingAdminControlLogs
    Friend WithEvents StaffListReport1 As Login.StaffListReport
    Friend WithEvents StudentListReport1 As Login.StudentListReport
    Friend WithEvents subjectlist1 As Login.subjectlist
    Friend WithEvents System_LogsReport1 As Login.System_LogsReport
    Friend WithEvents TemporaryScheduleListReport1 As Login.TemporaryScheduleListReport
End Class
