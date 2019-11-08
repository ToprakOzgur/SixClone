using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class GamePlayState : BaseState
{
    public static event Action OnGamePlayActivated = delegate { };
    public override void OnActivate()
    {

        Managers.Game.isGameplayActive = true;
        Managers.UI.pauseButton.gameObject.SetActive(true);
        Managers.Spawner.collectableArea.SetActive(true);
        OnGamePlayActivated();
    }

    public override void OnDeactivate()
    {


    }

    public override void OnUpdate()
    {

    }
}
