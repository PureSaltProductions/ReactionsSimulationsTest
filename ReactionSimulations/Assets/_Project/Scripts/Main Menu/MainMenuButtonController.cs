using UnityEngine;
using Zenject;

public class MainMenuButtonController : MonoBehaviour
{
    private SignalBus _signalBus;

    [Inject]
    private void Construct(SignalBus signalBus)
    {
        _signalBus = signalBus;
    }

    private void Awake()
    {
        _signalBus.Subscribe<MainMenuButtonSignal>(OnMainMenuButtonSignal);
    }

    private void OnMainMenuButtonSignal(MainMenuButtonSignal signal)
    {
        switch (signal.ButtonType)
        {
            case MainMenuButton.ButtonType.Play:
                OnPlayClicked();
                break;
            case MainMenuButton.ButtonType.Exit:
                OnExitclicked();
                break;
        }
    }

    private void OnPlayClicked()
    {
        Debug.Log("Play clicked");
        // Load the game scene
        SceneController.LoadGame();
    }

    private void OnExitclicked()
    {
        Debug.Log("Exit clicked");
        // Exit the game
        Application.Quit();
    }

    private void OnDestroy()
    {
        _signalBus.Unsubscribe<MainMenuButtonSignal>(OnMainMenuButtonSignal);
    }
}
