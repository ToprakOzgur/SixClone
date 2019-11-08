using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableController : MonoBehaviour
{
    private int collectableItemCount;
    public int CollectableItemCount
    {
        get
        {
            return collectableItemCount;
        }
        set
        {
            collectableItemCount = value;
            PlayerPrefs.SetInt("stars", value);
            Managers.UI.UpdateCollectableText(value);
        }
    }

    private void Start()
    {
        CollectableItemCount = PlayerPrefs.GetInt("stars", 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            transform.position += Vector3.down * 10;
            CollectableItemCount++;
        }
    }
}

