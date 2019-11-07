using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private Queue<List<GameObject>> blockGroupsQueue = new Queue<List<GameObject>>();
    public Block[] allBlocks;

    private float currentSpawnPoint;

    private void Start()
    {
        //for visually distrubute of BlockGroup height
        var heights = IntegerRandomSeperator.RandomlySeperate(10);
        foreach (var height in heights)
        {
            GenerateBlockGroup(height);
            Debug.Log(height);
        }
    }

    private void GenerateBlockGroup(int height)
    {
        BlockGroup blockGroup = new BlockGroup(height);
        blockGroupsQueue.Enqueue(blockGroup.GenerateBlockGroup(currentSpawnPoint));
        currentSpawnPoint += (float)height / 2.0f;

    }

    public GameObject PlaceBlock(Block block, float yPos, Vector3 pos)
    {
        var newBlock = Instantiate(block.gameObject, pos + Vector3.down * yPos, block.transform.rotation);

        newBlock.GetComponentInChildren<Rigidbody2D>().isKinematic = true;

        return newBlock;
    }

    public void UnFreezeCurrentBlockGroup()
    {
        var currentBlockGroup = blockGroupsQueue.Dequeue();

        foreach (var block in currentBlockGroup)
        {
            block.GetComponentInChildren<Rigidbody2D>().isKinematic = false;
        }
    }
}
