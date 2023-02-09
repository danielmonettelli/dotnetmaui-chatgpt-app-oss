using ChatGPT.ViewModels;

namespace ChatGPT.Views;

public partial class ConversationView : ContentPage
{
    public ConversationView(ConversationViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;

        vm.CollectionView = myCollectionView;
        vm.ConversationView = mainPage;
    }

}