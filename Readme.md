<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655693/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T587066)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainViewModel.cs](./CS/WpfSchedulerTimeRulers/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/WpfSchedulerTimeRulers/MainViewModel.vb))
* **[MainWindow.xaml](./CS/WpfSchedulerTimeRulers/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfSchedulerTimeRulers/MainWindow.xaml))**
<!-- default file list end -->
# How to add multiple time rulers to the Scheduler and adjust their settings


<p>This example demonstrates how to add multiple time rulers to the <a href="https://documentation.devexpress.com/WPF/119204/Controls-and-Libraries/Scheduler/Views/Day-View">Day View</a> using the MVVM architectural pattern. <br>The <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DayViewBase.TimeRulersSource.property">DayViewBase.TimeRulersSource</a> property allows you to bind a scheduler view to a collection of objects containing time ruler settings described in the ViewModel. The <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DayViewBase.TimeRulerTemplate.property">DayViewBase.TimeRulerTemplate</a> property specifies a data template based on which time rulers are generated.<br>Create a custom style for the <strong>TimeRulerCellControl </strong>to<strong> </strong>specify format strings for displaying time in the time rulers' time scale. <br>The <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DayViewBase.TimeRulers.property">DayViewBase.TimeRulers</a> collection stores all time rulers for the current view. You can also use the collection's members to add, modify or remove time rulers.<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-add-multiple-time-rulers-to-the-scheduler-and-adjust-their-settings-t587066/17.2.3+/media/90f75ab6-4202-4587-acb0-560f08d9bae2.png"></p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-scheduler-generate-time-rulers-from-view-model-collection&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-scheduler-generate-time-rulers-from-view-model-collection&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
