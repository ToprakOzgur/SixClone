using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGroup
{
    private Queue<Block> blocks = new Queue<Block>();
    public int height { get; private set; }
    private const int width = 5;
    private bool[,] grid;

    public BlockGroup(int height)
    {
        this.height = height;
        grid = new bool[width, height];

    }

    public void GenerateBlockGroup()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (!grid[i, j])
                {
                    //find all suitable blocks
                    var suitableBlocks = FindAllSuitableBlockAtPoint();

                    //randomly select one
                    var selectedBlock = SelectOneSuitableBlock(suitableBlocks);

                    //Add new block to Queue
                    blocks.Enqueue(selectedBlock);

                    //register all new tiles to grid
                    RegisterBlockTilesToGrid((i, j), selectedBlock);
                }
            }
        }
    }


    private Block[] FindAllSuitableBlockAtPoint()
    {
        return null;
    }

    private Block SelectOneSuitableBlock(Block[] suitableBlocks)
    {
        var selectedBlockIndex = UnityEngine.Random.Range(0, suitableBlocks.Length);
        var selectedBlock = suitableBlocks[selectedBlockIndex];
        return selectedBlock;
    }

    private void RegisterBlockTilesToGrid((int, int) gridIndex, Block block)
    {
        foreach (var tile in block.tiles)
        {

            grid[gridIndex.Item1 + tile.cords.x, gridIndex.Item2 + tile.cords.y] = true;
        }
    }
}