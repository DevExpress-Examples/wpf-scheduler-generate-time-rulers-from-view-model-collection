<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655693/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T587066)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Scheduler - Generate Time Rulers From a View Model Collection

This example generates [time rulers](https://docs.devexpress.com/WPF/404183/controls-and-libraries/scheduler/visual-elements/time-ruler) from a collection. The [DayViewBase.TimeRulersSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DayViewBase.TimeRulersSource) property specifies the collection of objects that describe time ruler elements. The [DayViewBase.TimeRulerTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DayViewBase.TimeRulerTemplate) property allows you to define a data template used to generate time rulers. You can create a style for the [TimeRulerCellControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.Visual.TimeRulerCellControl) to customize generated time rulers.

The [DayViewBase.TimeRulers](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DayViewBase.TimeRulers) collection stores all time rulers for the current view. You can also use collection members to add, modify, or remove time rulers.
  
![image](./media/90f75ab6-4202-4587-acb0-560f08d9bae2.png) 

## Files to Review

* [MainWindow.xaml](./CS/WpfSchedulerTimeRulers/MainWindow.xaml)
* [MainViewModel.cs](./CS/WpfSchedulerTimeRulers/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/WpfSchedulerTimeRulers/MainViewModel.vb))

## Documentation

* [Time Ruler](https://docs.devexpress.com/WPF/404183/controls-and-libraries/scheduler/visual-elements/time-ruler)
* [TimeRuler](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.TimeRuler)
* [DayViewBase.TimeRulersSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DayViewBase.TimeRulersSource)
* [DayViewBase.TimeRulerTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DayViewBase.TimeRulerTemplate)

## More Examples

* [WPF Scheduler - Use Styles and Templates to Customize Time Rulers](https://github.com/DevExpress-Examples/wpf-scheduler-use-styles-and-templates-to-customize-time-rulers)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-scheduler-generate-time-rulers-from-view-model-collection&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-scheduler-generate-time-rulers-from-view-model-collection&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
