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
            PlayerPrefs.SetInt("highscore", value);

        }
    }

    private void Awake()
    {
        highScore = PlayerPrefs.GetInt("highscore", 0);
        GameScore = 0;
    }

}
