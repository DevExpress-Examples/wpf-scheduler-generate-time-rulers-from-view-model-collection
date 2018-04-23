Imports System
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm.POCO

Namespace WpfSchedulerTimeRulers
    Public Class MainViewModel
        Private privateTimeRulers As ObservableCollection(Of TimeRulerViewModel)
        Public Overridable Property TimeRulers() As ObservableCollection(Of TimeRulerViewModel)
            Get
                Return privateTimeRulers
            End Get
            Protected Set(ByVal value As ObservableCollection(Of TimeRulerViewModel))
                privateTimeRulers = value
            End Set
        End Property

        Protected Sub New()
            CreateTimeRulers()
        End Sub

        Private Sub CreateTimeRulers()
            TimeRulers = New ObservableCollection(Of TimeRulerViewModel)()
            TimeRulers.Add(TimeRulerViewModel.Create("GMT", TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time")))
            TimeRulers.Add(TimeRulerViewModel.Create("Local", TimeZoneInfo.Local))
        End Sub
    End Class

    Public Class TimeRulerViewModel
        Public Shared Function Create() As TimeRulerViewModel
            Return ViewModelSource.Create(Function() New TimeRulerViewModel())
        End Function

        Public Shared Function Create(ByVal caption As String, ByVal timeZoneInfo As TimeZoneInfo) As TimeRulerViewModel
            Dim timeRuler As TimeRulerViewModel = TimeRulerViewModel.Create()
            timeRuler.Caption = caption
            timeRuler.TimeZone = timeZoneInfo
            timeRuler.AlwaysShowTimeDesignator = False
            timeRuler.ShowMinutes = False
            Return timeRuler
        End Function

        Protected Sub New()
        End Sub
        Public Overridable Property Caption() As String
        Public Overridable Property TimeZone() As TimeZoneInfo
        Public Overridable Property AlwaysShowTimeDesignator() As Boolean
        Public Overridable Property ShowMinutes() As Boolean
    End Class
End Namespace
