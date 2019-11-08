using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuState : BaseState
{
    public override void OnActivate()
    {
        Managers.UI.scoreText.gameObject.SetActive(false);
        Managers.UI.pauseButton.gameObject.SetActive(false);
    }

    public override void OnDeactivate()
    {
        Managers.Spawner.GenerateBlockGroup(10);
        Managers.Spawner.GenerateBlockGroup(10);
        Managers.UI.menuPanel.SetActive(false);
        Managers.Spawner.player.SetActive(true);
    }

    public override void OnUpdate()
    {

    }
}
