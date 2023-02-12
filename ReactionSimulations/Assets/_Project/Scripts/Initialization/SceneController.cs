using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

/// <summary>
/// Controller class for loading between the scenes in the game.
/// </summary>
public static class SceneController
{
    public static void LoadInitialization()
    {
        SceneManager.LoadScene(MagicString.Scenes.Initialization);
    }

    public static void LoadMainMenu()
    {
        SceneManager.LoadScene(MagicString.Scenes.MainMenu);
    }

    public static void LoadGame()
    {
        SceneManager.LoadScene(MagicString.Scenes.Game);
    }
}
