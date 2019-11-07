using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchContoller : MonoBehaviour
{
    private void OnMouseDown()
    {
        transform.parent.gameObject.SetActive(false);
    }
}
