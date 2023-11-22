Imports DevExpress.Xpf.Scheduling

Namespace WpfSchedulerTimeRulers

    Public Partial Class MainWindow
        Inherits DevExpress.Xpf.Core.ThemedWindow

        Public Sub New()
            Me.InitializeComponent()
            ' Create a test appointment.
            Me.scheduler.AppointmentItems.Add(New AppointmentItem() With {.Start = Date.Now.Date.AddHours(13), .[End] = Date.Now.Date.AddHours(14), .LabelId = 1, .StatusId = 2, .Subject = "Phone Call"})
        End Sub
    End Class
End Namespace
