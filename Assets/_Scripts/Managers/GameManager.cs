﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public bool isGameplayActive;
    private BaseState currentState;
    public BaseState CurrentState
    {
        get { return currentState; }
    }

    //Changes the current game state
    public void SetState(System.Type newStateType)
    {
        if (currentState != null)
        {
            currentState.OnDeactivate();
        }

        currentState = GetComponentInChildren(newStateType) as BaseState;

        if (currentState != null)
        {
            currentState.OnActivate();
        }
    }

    private void Start()
    {
        SetState(typeof(MenuState));
    }
    void Update()
    {
        if (currentState != null)
        {
            currentState.OnUpdate();
        }
    }
}
