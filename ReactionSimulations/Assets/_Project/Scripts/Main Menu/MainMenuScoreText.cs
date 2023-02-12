using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

public class MainMenuScoreText : MonoBehaviour
{
    private const string HIGH_SCORE_PRETEXT = "High Score: ";
    private const string PREVIOUS_SCORE_PRETEXT = "Previous Score: ";

    public enum ScoreType
    {
        HighScore,
        PreviousScore
    }

    private PersistantData _persistantData;
    private TMPro.TextMeshProUGUI _text;
    [SerializeField]
    private string _scorePretext;
    [SerializeField]
    private ScoreType _scoreType;

    [Inject]
    private void Construct(PersistantData persistantData)
    {
        _persistantData = persistantData;
    }

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        _text = GetComponent<TextMeshProUGUI>();
        CheckPretextSetup();
        UpdateScoreText();
    }

    private void CheckPretextSetup()
    {
        if(_scorePretext == "" || _scorePretext == null)
        {
            switch(_scoreType)
            {
                case ScoreType.HighScore:
                    _scorePretext = HIGH_SCORE_PRETEXT;
                    break;
                case ScoreType.PreviousScore:
                    _scorePretext = PREVIOUS_SCORE_PRETEXT;
                    break;
            }
        }
    }

    private void UpdateScoreText()
    {
        switch (_scoreType)
        {
            case ScoreType.HighScore:
                _text.text = $"{_scorePretext} {_persistantData.ScoreData.HighScore}";
                break;
            case ScoreType.PreviousScore:
                _text.text = $"{_scorePretext} {_persistantData.ScoreData.PreviousScore}";
                break;
        }
    }
}
