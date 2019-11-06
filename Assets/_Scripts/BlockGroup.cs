using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGroup
{
    public int height { get; private set; }
    private const int width = 5;

    private bool[,] grid;
    public BlockGroup(int height)
    {
        this.height = height;
        grid = new bool[width, height];

    }

    public void GenerateBlockGroup(Vector2 spawnPoint, Block[] blocks)
    {

    }


}