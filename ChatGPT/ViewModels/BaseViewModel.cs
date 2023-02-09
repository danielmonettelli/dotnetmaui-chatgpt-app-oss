using CommunityToolkit.Mvvm.ComponentModel;

namespace ChatGPT.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        bool isBusy;
    }
}
