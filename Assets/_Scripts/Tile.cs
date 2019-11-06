using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Cords cords;
    public bool isValidPosition(BlockGroup blockGroup)
    {


        //check if in blockgroup
        //check if in grid is empty
        return true;
    }

    [System.Serializable]
    public struct Cords
    {
        public int x;
        public int y;
    }
}
