using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchContoller : MonoBehaviour
{
    public static bool isPlayerStartedToTouch;
    private void OnMouseDown()
    {
        transform.parent.gameObject.SetActive(false);
        isPlayerStartedToTouch = true;
    }
}
