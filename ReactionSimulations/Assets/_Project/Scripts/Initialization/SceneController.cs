using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

/// <summary>
/// Controller class for loading between the scenes in the game.
/// </summary>
public class SceneController
{
    public void LoadInitialization()
    {
        SceneManager.LoadScene(MagicString.Scenes.Initialization);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(MagicString.Scenes.MainMenu);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(MagicString.Scenes.Game);
    }
}
