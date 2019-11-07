using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBlockSpwanDetector : MonoBehaviour
{
    [SerializeField] private int spwanDistance;
    [SerializeField] private int unFreezeDistance;
    [SerializeField] private Transform playerTransform;
    private WaitForSeconds checkInterval = new WaitForSeconds(0.1f); //created first beacause of Garbage collections optimizition . just a few bytes:)


    private void OnEnable()
    {
        GamePlayState.OnGamePlayActivated += StartChecking;
    }
    private void OnDisable()
    {
        GamePlayState.OnGamePlayActivated -= StartChecking;
    }
    public void StartChecking()
    {
        StartCoroutine(CheckIfBlockNeeded());
    }
    private IEnumerator CheckIfBlockNeeded()
    {
        while (Managers.Game.isGameplayActive)
        {
            if (playerTransform.position.y - transform.position.y < spwanDistance)
            {
                transform.position += Vector3.down * spwanDistance;
                Managers.Spawner.GenerateBlockGroup();
            }

            if (playerTransform.position.y - Managers.Spawner.GetCurrentBlockStartPoint() < unFreezeDistance)
            {
                Managers.Spawner.UnFreezeCurrentBlockGroup();
            }

            yield return checkInterval;
        }
    }

}
