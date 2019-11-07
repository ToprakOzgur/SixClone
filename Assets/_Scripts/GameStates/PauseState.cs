using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseState : BaseState
{
    public override void OnActivate()
    {
        Managers.UI.pausePanel.SetActive(true);
        Managers.Game.isGameplayActive = false;
    }

    public override void OnDeactivate()
    {

    }

    public override void OnUpdate()
    {

    }
}
