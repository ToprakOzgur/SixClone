using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    public bool isfollowing = false;

    private void OnEnable()
    {
        GameOverState.OnPlayerDied += StopFlollow;
    }
    private void OnDisable()
    {
        GameOverState.OnPlayerDied -= StopFlollow;
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
        isfollowing = false;
    }
}
