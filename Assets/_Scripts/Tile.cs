using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Cords cords;
    public bool isPositionValid(BlockGroup blockGroup, Vector3 parentPositon)
    {


        //check if in blockgroup
        //check if in grid is empty
        return true;
    }

    public (int, int) GetCurrentGridAtPosition(bool[,] grid, Vector2 pos)
    {

        return (0, 0);
    }

    [System.Serializable]
    public struct Cords
    {
        public int x;
        public int y;
    }
}
