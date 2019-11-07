using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int gameScore;
    public int GameScore
    {
        get
        {
            return gameScore;
        }
        set
        {
            gameScore = value;
            Managers.UI.scoreText.text = gameScore.ToString();

            if (value > HighScore)
            {
                HighScore = value;
            }
        }
    }

    private int highScore;
    public int HighScore
    {
        get
        {
            return highScore;
        }
        set
        {
            highScore = value;
            Managers.UI.highScoreText.text = highScore.ToString();
            PlayerPrefs.SetInt("highscore", highScore);
        }
    }

    private void Awake()
    {
        HighScore = PlayerPrefs.GetInt("highscore", 0);
        GameScore = 0;
    }

}
