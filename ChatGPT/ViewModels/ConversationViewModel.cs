using ChatGPT.Models;
using ChatGPT.Services;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ChatGPT.ViewModels
{
    public partial class ConversationViewModel : BaseViewModel
    {
        [ObservableProperty]
        string query;

        [ObservableProperty]
        bool isAnimationVisible = true;

        [ObservableProperty]
        ObservableCollection<Message> messages = new();

        [ObservableProperty]
        CollectionView collectionView;

        [ObservableProperty]
        ContentPage conversationView;

        [ObservableProperty]
        double opacityModeMessage = 1;

        [ObservableProperty]
        double opacityModeImage = 0.5;

        [ObservableProperty]
        private Message theMessage = new();

        IOpenAIService _openAIService;
        IDispatcher _dispatcher;

        private AsyncRelayCommand _currentCommand;

        public AsyncRelayCommand CurrentCommand
        {
            get
            {
                return _currentCommand ??= new AsyncRelayCommand(AskQuestionAsync);
            }
            set
            {
                SetProperty(ref _currentCommand, value);
            }
        }

        public ConversationViewModel(IOpenAIService openAIService, IDispatcher dispatcher)
        {
            _openAIService = openAIService;
            _dispatcher = dispatcher;
        }

        private void AddMessage(string message, bool isUserMessage)
        {
            if (Messages.Count <= 0) IsAnimationVisible = false;

            Messages.Add(new Message
            {
                Text = message,
                IsUserMessage = isUserMessage,
                IsTextActive = TheMessage.IsTextActive,
                IsImageActive = TheMessage.IsImageActive
            });

            Task.Delay(150).ContinueWith(t =>
            {
                _dispatcher.Dispatch(() =>
                {
                    CollectionView.ScrollTo
                    (
                        item: Messages.Last(),
                        position: ScrollToPosition.End,
                        animate: true
                    );
                });
            });
        }

        private async Task QueryManagerAsync(Func<string, Task<string>> queryManager)
        {
            if (string.IsNullOrEmpty(Query)) return;
            string queryCopy = Query;
            Query = string.Empty;
            AddMessage(message: queryCopy, isUserMessage: true);
            IsBusy = true;
            string answer = await queryManager(queryCopy);
            AddMessage(message: answer.TrimStart(), isUserMessage: false);
            IsBusy = false;
        }

        private async Task AskQuestionAsync()
        {
            TheMessage.IsTextActive = true;
            TheMessage.IsImageActive = false;

            await QueryManagerAsync(_openAIService.AskQuestion);
        }

        private async Task CreateImageAsync()
        {
            TheMessage.IsTextActive = false;
            TheMessage.IsImageActive = true;

            await QueryManagerAsync(_openAIService.CreateImage);
        }

        [RelayCommand]
        private async Task AskQuestion()
        {
            OpacityModeMessage = 1;
            OpacityModeImage = 0.5;

            await Toast.Make("Write mode").Show();

            CurrentCommand = new AsyncRelayCommand(AskQuestionAsync);
        }

        [RelayCommand]
        private async Task CreateImage()
        {
            OpacityModeMessage = 0.5;
            OpacityModeImage = 1;

            await Toast.Make("Image mode").Show();

            CurrentCommand = new AsyncRelayCommand(CreateImageAsync);
        }

        [RelayCommand]
        private async Task SelectTheme()
        {
            AppTheme currentTheme = Application.Current.RequestedTheme;
            AppTheme newTheme = currentTheme == AppTheme.Dark ? AppTheme.Light : AppTheme.Dark;
            Application.Current.UserAppTheme = newTheme;

            await ConversationView.ScaleTo(0.95, 250, Easing.CubicOut);
            await ConversationView.ScaleTo(1.05, 250, Easing.CubicIn);
            await ConversationView.ScaleTo(1, 250, Easing.CubicOut);
        }

    }

}
