using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Tile[] tiles;

    public bool isValid()
    {
        foreach (var tile in tiles)
        {
            //  tile.isValidPosition();
        }
        return true;
    }

}
