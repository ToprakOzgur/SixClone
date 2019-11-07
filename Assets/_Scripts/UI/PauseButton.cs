using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public void OnButtonPressed()
    {
        Managers.Game.SetState(typeof(PauseState));
    }
}
