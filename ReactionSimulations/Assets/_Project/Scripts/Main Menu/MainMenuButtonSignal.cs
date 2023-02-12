public class MainMenuButtonSignal
{
    public MainMenuButton.ButtonType ButtonType { get; private set; }

    public MainMenuButtonSignal(MainMenuButton.ButtonType buttonType)
    {
        ButtonType = buttonType;
    }
}
