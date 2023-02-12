using Zenject;

/// <summary>
/// This is a helper class to store all the magic strings used in the project.
/// </summary>
public static class MagicString
{
    /// <summary>
    /// Magic strings for Score data
    /// </summary>
    public static class Score
    {
        public const string HighScore = "HighScore";
        public const string PreviousScore = "PreviousScore";
    }

    /// <summary>
    /// Magic strings for Scenes
    /// </summary>
    public static class Scenes
    {
        public const string Initialization = "Initialization";
        public const string MainMenu = "MainMenu";
        public const string Game = "Game";
    }
}