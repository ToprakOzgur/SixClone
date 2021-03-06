﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class BaseState : MonoBehaviour
{

    public abstract void OnActivate();
    public abstract void OnDeactivate();
    public abstract void OnUpdate();
}
