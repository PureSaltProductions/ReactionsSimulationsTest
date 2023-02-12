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

    private Score _scoreData = new Score();

    public Score ScoreData { get => _scoreData; set => _scoreData = value; }

    public void Initialize()
    {

    }
}
