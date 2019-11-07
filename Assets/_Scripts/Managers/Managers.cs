using UnityEngine;
using System.Collections;

[RequireComponent(typeof(GameManager))]
[RequireComponent(typeof(UIManager))]
[RequireComponent(typeof(ScoreManager))]
[RequireComponent(typeof(SpawnManager))]
[RequireComponent(typeof(ColorManager))]

public class Managers : MonoBehaviour
{
    public static GameManager Game { get; private set; }
    public static UIManager UI { get; private set; }
    public static ScoreManager Score { get; private set; }
    public static SpawnManager Spawner { get; private set; }
    public static ColorManager Color { get; private set; }

    void Awake()
    {
        Game = GetComponent<GameManager>();
        UI = GetComponent<UIManager>();
        Score = GetComponent<ScoreManager>();
        Spawner = GetComponent<SpawnManager>();
        Color = GetComponent<ColorManager>();
    }


}

