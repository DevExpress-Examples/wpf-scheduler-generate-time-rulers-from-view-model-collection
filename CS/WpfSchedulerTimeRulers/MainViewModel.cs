using System;
using System.Collections.ObjectModel;
using DevExpress.Mvvm.POCO;

namespace WpfSchedulerTimeRulers
{
    public class MainViewModel
    {
        public virtual ObservableCollection<TimeRulerViewModel> TimeRulers { get; protected set; }

        protected MainViewModel()
        {
            CreateTimeRulers();
        }

        private void CreateTimeRulers()
        {
            TimeRulers = new ObservableCollection<TimeRulerViewModel>();
            TimeRulers.Add(TimeRulerViewModel.Create("GMT", TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time")));
            TimeRulers.Add(TimeRulerViewModel.Create("Local", TimeZoneInfo.Local));
        }
    }

    public class TimeRulerViewModel
    {
        public static TimeRulerViewModel Create()
        {
            return ViewModelSource.Create(() => new TimeRulerViewModel());
        }

        public static TimeRulerViewModel Create(string caption, TimeZoneInfo timeZoneInfo)
        {
            TimeRulerViewModel timeRuler = TimeRulerViewModel.Create();
            timeRuler.Caption = caption;
            timeRuler.TimeZone = timeZoneInfo;
            timeRuler.AlwaysShowTimeDesignator = false;
            timeRuler.ShowMinutes = false;
            return timeRuler;
        }

        protected TimeRulerViewModel() { }
        public virtual string Caption { get; set; }
        public virtual TimeZoneInfo TimeZone { get; set; }
        public virtual bool AlwaysShowTimeDesignator { get; set; }
        public virtual bool ShowMinutes { get; set; }
    }
}
