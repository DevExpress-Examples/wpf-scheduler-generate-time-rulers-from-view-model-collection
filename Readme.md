<!-- default file list -->
*Files to look at*:

* [MainViewModel.cs](./CS/WpfSchedulerTimeRulers/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/WpfSchedulerTimeRulers/MainViewModel.vb))
* **[MainWindow.xaml](./CS/WpfSchedulerTimeRulers/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfSchedulerTimeRulers/MainWindow.xaml))**
<!-- default file list end -->
# How to add multiple time rulers to the Scheduler and adjust their settings


<p>This example demonstrates how to add multiple time rulers to the <a href="https://documentation.devexpress.com/WPF/119204/Controls-and-Libraries/Scheduler/Views/Day-View">Day View</a> using the MVVM architectural pattern. <br>The <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DayViewBase.TimeRulersSource.property">DayViewBase.TimeRulersSource</a> property allows you to bind a scheduler view to a collection of objects containing time ruler settings described in the ViewModel. The <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DayViewBase.TimeRulerTemplate.property">DayViewBase.TimeRulerTemplate</a> property specifies a data template based on which time rulers are generated.<br>Create a custom style for the <strong>TimeRulerCellControl </strong>to<strong> </strong>specify format strings for displaying time in the time rulers' time scale. <br>The <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DayViewBase.TimeRulers.property">DayViewBase.TimeRulers</a> collection stores all time rulers for the current view. You can also use the collection's members to add, modify or remove time rulers.<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-add-multiple-time-rulers-to-the-scheduler-and-adjust-their-settings-t587066/17.2.3+/media/90f75ab6-4202-4587-acb0-560f08d9bae2.png"></p>

<br/>


