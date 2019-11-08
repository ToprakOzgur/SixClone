using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButton : BaseButton
{
    public override void OnButtonPressed()
    {
        Managers.UI.pausePanel.SetActive(false);
        Managers.UI.pauseButton.SetActive(true);
        Managers.Game.SetState(typeof(GamePlayState));
    }
}
