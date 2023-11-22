using System;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;

namespace WpfSchedulerTimeRulers {
    public class MainViewModel : ViewModelBase {
        public ObservableCollection<TimeRulerViewModel> TimeRulers { get; protected set; }

        public MainViewModel() {
            CreateTimeRulers();
        }

        private void CreateTimeRulers() {
            TimeRulers = new ObservableCollection<TimeRulerViewModel> {
                new TimeRulerViewModel("GMT", TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time")),
                new TimeRulerViewModel("Local", TimeZoneInfo.Local)
            };
        }
    }

    public class TimeRulerViewModel : BindableBase {
        public TimeRulerViewModel(string caption, TimeZoneInfo timeZoneInfo) {
            Caption = caption;
            TimeZone = timeZoneInfo;
            AlwaysShowTimeDesignator = false;
            ShowMinutes = false;
        }
        public string Caption { get; set; }
        public TimeZoneInfo TimeZone { get; set; }
        public bool AlwaysShowTimeDesignator { get; set; }
        public bool ShowMinutes { get; set; }
    }
}
