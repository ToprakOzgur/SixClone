using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Size size;

    [System.Serializable]
    public struct Size
    {
        public int width;
        public int height;
    }
}
