﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : BaseButton
{
    public override void OnButtonPressed()
    {
        Managers.Game.SetState(typeof(PauseState));
    }

}
