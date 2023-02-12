using UnityEngine;
using Zenject;

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
