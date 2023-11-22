using DevExpress.Xpf.Scheduling;
using System;

namespace WpfSchedulerTimeRulers {
    public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow {
        public MainWindow() {
            InitializeComponent();

            // Create a test appointment.
            scheduler.AppointmentItems.Add(new AppointmentItem() { Start = DateTime.Now.Date.AddHours(13), End = DateTime.Now.Date.AddHours(14), LabelId = 1, StatusId = 2, Subject = "Phone Call" });
        }
    }
}
