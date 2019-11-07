using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    private bool isfollowing = true;

    private void OnEnable()
    {
        GamePlayAreaController.OnPlayerDied += StopFlollow;
    }
    private void OnDisable()
    {
        GamePlayAreaController.OnPlayerDied -= StopFlollow;
    }
    private void Update()
    {
        if (!isfollowing)
        {
            return;
        }

        transform.position = new Vector3(0, target.position.y, 0);
    }

    public void StopFlollow()
    {
        Debug.Log("dead");
        isfollowing = false;
    }
}
