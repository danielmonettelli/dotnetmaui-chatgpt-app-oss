namespace ChatGPT.Views.Templates;

public partial class BotMessageItemTemplate : Grid
{
    private Grid _parentGrid;

    public BotMessageItemTemplate()
    {
        InitializeComponent();

        borderText.SizeChanged += BorderText_SizeChanged;
    }

    private void ParentGrid_SizeChanged(object sender, EventArgs e)
    {
        var parentGrid = (Grid)sender;

        _parentGrid = parentGrid;

        BorderText_SizeChanged(borderText, e);
    }

    private void BorderText_SizeChanged(object sender, EventArgs e)
    {
        var borderText = (Border)sender;

        var widthMaxBorderText = _parentGrid.Width - 45;

        if (borderText.Width > widthMaxBorderText)
        {
            Dispatcher.Dispatch(() =>
            {
                borderText.WidthRequest = widthMaxBorderText;
            });
        }
    }
}