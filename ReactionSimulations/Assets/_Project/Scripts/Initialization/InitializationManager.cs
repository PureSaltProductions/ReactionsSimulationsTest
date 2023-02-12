using UnityEngine;
using Zenject;

/// <summary>
/// A monobehavior class that is responsible for initializing the game.
/// </summary>
public class InitializationManager : MonoBehaviour
{
    void Start()
    {
        SceneController.LoadMainMenu();
    }
}
