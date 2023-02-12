using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

/// <summary>
/// This class will be utilized to store and access data that is persistant
/// between game plays and scenes.
/// 
/// Example: Player's high score
/// </summary>
public class PersistantData : IInitializable
{
    public class Score
    {
        public float HighScore
        {
            get => PlayerPrefs.GetFloat(MagicString.Score.HighScore, 0);
            set => PlayerPrefs.SetFloat(MagicString.Score.HighScore, value);
        }

        public float PreviousScore 
        { 
            get => PlayerPrefs.GetFloat(MagicString.Score.PreviousScore, 0); 
            set => PlayerPrefs.SetFloat(MagicString.Score.PreviousScore, value); 
        }
    }

    private Score _scoreData;

    public Score ScoreData { get => _scoreData; set => _scoreData = value; }

    public void Initialize()
    {
        //// Load high score from player prefs
        //_scoreData.HighScore = PlayerPrefs.GetFloat(MagicString.HighScore, 0);
        //// Load previous score from player prefs
        //_scoreData.PreviousScore = PlayerPrefs.GetFloat(MagicString.PreviousScore, 0);
    }
}
