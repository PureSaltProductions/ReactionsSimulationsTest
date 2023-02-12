using UnityEngine;
using Zenject;

/// <summary>
/// A monobehavior class that is responsible for initializing the game.
/// </summary>
public class InitializationManager : MonoBehaviour
{
    private SceneController _sceneController;

    [Inject]
    private void Construct(SceneController sceneController)
    {
        _sceneController = sceneController;
    }

    void Start()
    {
        _sceneController.LoadMainMenu();
    }
}
