﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class BlockGroup
{

    public List<GameObject> blocks = new List<GameObject>();
    public int height { get; private set; }
    private const int width = 5;
    private bool[,] grid;

    public BlockGroup(int height)
    {
        this.height = height;
        grid = new bool[width, height];

    }

    public List<GameObject> GenerateBlockGroup(float yPos)
    {
        var blockColor = Managers.Color.GetRandomColor();
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {

                if (!grid[i, j])
                {
                    //find all suitable blocks
                    var suitableBlocks = FindAllSuitableBlocksAtPoint((i, j));
                    //randomly select one
                    var selectedBlock = SelectOneSuitableBlock(suitableBlocks);

                    var blockGameobject = Managers.Spawner.PlaceBlock(selectedBlock, yPos, new Vector3((float)i / 2 - 1.26f, -(float)j / 2.0f + 0.01f));
                    blockGameobject.GetComponentInChildren<SpriteRenderer>().color = blockColor;
                    //Add new block to list
                    blocks.Add(blockGameobject);

                    //register all new tiles to grid
                    RegisterBlockTilesToGrid((i, j), selectedBlock);
                }
            }
        }

        return blocks;
    }


    private List<Block> FindAllSuitableBlocksAtPoint((int, int) gridIndex)
    {
        var suitableBlocks = new List<Block>();
        var blocks = Managers.Spawner.allBlocks.Where(x => x.isValid(gridIndex, grid));
        suitableBlocks.AddRange(blocks);

        return suitableBlocks;
    }

    private Block SelectOneSuitableBlock(List<Block> suitableBlocks)
    {
        var selectedBlockIndex = UnityEngine.Random.Range(0, suitableBlocks.Count);
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