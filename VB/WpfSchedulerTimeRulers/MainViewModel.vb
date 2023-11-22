Imports System
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm

Namespace WpfSchedulerTimeRulers

    Public Class MainViewModel
        Inherits ViewModelBase

        Private _TimeRulers As ObservableCollection(Of WpfSchedulerTimeRulers.TimeRulerViewModel)

        Public Property TimeRulers As ObservableCollection(Of TimeRulerViewModel)
            Get
                Return _TimeRulers
            End Get

            Protected Set(ByVal value As ObservableCollection(Of TimeRulerViewModel))
                _TimeRulers = value
            End Set
        End Property

        Public Sub New()
            CreateTimeRulers()
        End Sub

        Private Sub CreateTimeRulers()
            TimeRulers = New ObservableCollection(Of TimeRulerViewModel) From {New TimeRulerViewModel("GMT", TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time")), New TimeRulerViewModel("Local", TimeZoneInfo.Local)}
        End Sub
    End Class

    Public Class TimeRulerViewModel
        Inherits BindableBase

        Public Sub New(ByVal caption As String, ByVal timeZoneInfo As TimeZoneInfo)
            Me.Caption = caption
            TimeZone = timeZoneInfo
            AlwaysShowTimeDesignator = False
            ShowMinutes = False
        End Sub

        Public Property Caption As String

        Public Property TimeZone As TimeZoneInfo

        Public Property AlwaysShowTimeDesignator As Boolean

        Public Property ShowMinutes As Boolean
    End Class
End Namespace
