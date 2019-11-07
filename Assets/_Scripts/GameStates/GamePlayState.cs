using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class GamePlayState : BaseState
{
    public static event Action OnGamePlayActivated = delegate { };
    public override void OnActivate()
    {
        Debug.Log("GamePlayState");
        Managers.Game.isGameplayActive = true;
        OnGamePlayActivated();
    }

    public override void OnDeactivate()
    {
        Managers.Game.isGameplayActive = false;

    }

    public override void OnUpdate()
    {

    }
}
