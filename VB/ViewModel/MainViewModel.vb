Imports DevExpress.Mvvm
Imports Example.Service

Namespace Example.ViewModel
    Public Class MainViewModel
        Inherits ViewModelBase

        Private ReadOnly Property CustomMessageBoxService() As ICustomMessageBoxService
            Get
                Return GetService(Of ICustomMessageBoxService)()
            End Get
        End Property
        Private privateShowMessageCommand As DelegateCommand
        Public Property ShowMessageCommand() As DelegateCommand
            Get
                Return privateShowMessageCommand
            End Get
            Private Set(ByVal value As DelegateCommand)
                privateShowMessageCommand = value
            End Set
        End Property
        Private Sub ShowMessage()
            CustomMessageBoxService.Show()
        End Sub
        Public Sub New()
            ShowMessageCommand = New DelegateCommand(AddressOf ShowMessage)
        End Sub
    End Class
End Namespace
