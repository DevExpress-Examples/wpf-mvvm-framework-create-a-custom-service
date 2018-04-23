Imports DevExpress.Mvvm.UI
Imports System.Windows

Namespace Example.Service
    Public Class CustomMessageBoxService
        Inherits ServiceBase
        Implements ICustomMessageBoxService

        Public Shared ReadOnly MessageProperty As DependencyProperty = DependencyProperty.Register("Message", GetType(String), GetType(CustomMessageBoxService), New PropertyMetadata("Hello"))
        Public Property Message() As String
            Get
                Return CStr(GetValue(MessageProperty))
            End Get
            Set(ByVal value As String)
                SetValue(MessageProperty, value)
            End Set
        End Property
        Private Sub ICustomMessageBoxService_Show() Implements ICustomMessageBoxService.Show
            MessageBox.Show(Message)
        End Sub
    End Class
End Namespace
