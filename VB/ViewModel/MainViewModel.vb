Imports DevExpress.Mvvm
Imports Example.Service

Namespace Example.ViewModel

    Public Class MainViewModel
        Inherits ViewModelBase

        Private _ShowMessageCommand As DelegateCommand

        Private ReadOnly Property CustomMessageBoxService As ICustomMessageBoxService
            Get
                Return GetService(Of ICustomMessageBoxService)()
            End Get
        End Property

        Public Property ShowMessageCommand As DelegateCommand
            Get
                Return _ShowMessageCommand
            End Get

            Private Set(ByVal value As DelegateCommand)
                _ShowMessageCommand = value
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
