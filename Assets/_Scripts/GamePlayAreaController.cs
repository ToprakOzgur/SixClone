using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayAreaController : MonoBehaviour
{
    public static event Action OnPlayerDied = delegate { };
    private void OnTriggerEnter2D(Collider2D other)
    {
        OnPlayerDied();
    }

}
