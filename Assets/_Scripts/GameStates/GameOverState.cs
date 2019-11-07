using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOverState : BaseState
{
    public static event Action OnPlayerDied = delegate { };
    public override void OnActivate()
    {
        OnPlayerDied();
        Managers.Game.isGameplayActive = false;
        PlayerPrefs.Save();

    }

    public override void OnDeactivate()
    {

    }

    public override void OnUpdate()
    {

    }
}
