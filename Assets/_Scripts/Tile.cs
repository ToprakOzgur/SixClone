using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Cords cords;


    [System.Serializable]
    public struct Cords
    {
        public int x;
        public int y;
    }
}
