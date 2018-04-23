Imports DevExpress.Xpf.Scheduling
Imports System

Namespace WpfSchedulerTimeRulers
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits DevExpress.Xpf.Core.ThemedWindow

        Public Sub New()
            InitializeComponent()

            ' Create a test appointment.
            scheduler.AppointmentItems.Add(New AppointmentItem() With { _
                .Start = Date.Now.Date.AddHours(13), _
                .End = Date.Now.Date.AddHours(14), _
                .LabelId = 1, _
                .StatusId = 2, _
                .Subject = "Phone Call" _
            })
        End Sub
    End Class
End Namespace
