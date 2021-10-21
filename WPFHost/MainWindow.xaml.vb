Imports System.ServiceModel
Imports System.Threading
Imports HelloWCF

Partial Public Class MainWindow
    Inherits Window

    Public Sub New()
        InitializeComponent()
        btnStart.IsEnabled = True
        btnStop.IsEnabled = False
        Me.Title = "UI Running on Thread " & Thread.CurrentThread.ManagedThreadId
    End Sub

    Private _HostAliveIdea As ServiceHost = Nothing

    Private Sub btnStart_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        _HostAliveIdea = New ServiceHost(GetType(AliveIdeaService))
        _HostAliveIdea.Open()
        btnStart.IsEnabled = False
        btnStop.IsEnabled = True
    End Sub

    Private Sub btnStop_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        _HostAliveIdea.Close()
        btnStart.IsEnabled = True
        btnStop.IsEnabled = False
    End Sub
End Class
