using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBlockSpwanDetector : MonoBehaviour
{
    [SerializeField] private int distance;
    [SerializeField] private Transform playerTransform;

    private void Update()
    {
        if (playerTransform.position.y - transform.position.y < distance)
        {
            transform.position += Vector3.down * 5;
            Debug.Log("spawn new block");
        }

    }
}
