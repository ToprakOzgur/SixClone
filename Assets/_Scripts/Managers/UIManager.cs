using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    public GameObject pausePanel;
    public GameObject pauseButton;
    public GameObject lastCallText;
    public GameObject menuPanel;
    public Text collectableCountText;

    public void UpdateCollectableText(int amount)
    {
        collectableCountText.text = amount.ToString();
    }
}
