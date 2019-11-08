using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseState : BaseState
{
    public override void OnActivate()
    {
        Managers.UI.pausePanel.SetActive(true);
        Managers.Game.isGameplayActive = false;
        Time.timeScale = 0;
    }

    public override void OnDeactivate()
    {
        Time.timeScale = 1;
    }

    public override void OnUpdate()
    {

    }
}
