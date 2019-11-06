using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Tile[] tiles;

    public bool isValid((int, int) gridIndex, bool[,] grid)
    {
        foreach (var tile in tiles)
        {

            //check if tile in grid
            var isNotInGrid = (gridIndex.Item1 + tile.cords.x >= grid.GetLength(0))
                            || (gridIndex.Item2 + tile.cords.y >= grid.GetLength(1))
                            || (gridIndex.Item1 + tile.cords.x < 0)
                            || (gridIndex.Item2 + tile.cords.y < 0);

            if (isNotInGrid)
            {
                return false;
            }

            //check if grid empty
            var isGridFull = grid[gridIndex.Item1 + tile.cords.x, gridIndex.Item2 + tile.cords.y];
            if (isGridFull)
            {
                return false;
            }
        }

        return true;
    }

}
