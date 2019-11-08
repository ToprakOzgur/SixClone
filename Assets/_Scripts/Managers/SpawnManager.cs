using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private Transform blockHolder;
    private Queue<List<GameObject>> blockGroupsQueue = new Queue<List<GameObject>>();
    public Block[] allBlocks;
    public GameObject player;

    private float currentSpawnPoint;

    // private void Start()
    // {
    //     //startting with 2*10 line 
    //     GenerateBlockGroup(10);
    //     GenerateBlockGroup(10);
    // }

    public void GenerateBlockGroup(int height = 10)
    {
        var heights = IntegerRandomSeperator.RandomlySeperate(10); //for visually distribution of BlockGroup 

        foreach (var h in heights)
        {
            BlockGroup blockGroup = new BlockGroup(h);
            blockGroupsQueue.Enqueue(blockGroup.GenerateBlockGroup(currentSpawnPoint));
            currentSpawnPoint += (float)h / 2.0f;
        }
    }

    public GameObject PlaceBlock(Block block, float yPos, Vector3 pos)
    {
        var newBlock = Instantiate(block.gameObject, pos + Vector3.down * yPos, block.transform.rotation, blockHolder);
        newBlock.GetComponentInChildren<Rigidbody2D>().isKinematic = true;
        return newBlock;
    }

    public void UnFreezeCurrentBlockGroup()
    {
        if (!TouchContoller.isPlayerStartedToTouch)
        {
            return;
        }

        var currentBlockGroup = blockGroupsQueue.Dequeue();
        foreach (var block in currentBlockGroup)
        {
            block.GetComponentInChildren<Rigidbody2D>().isKinematic = false;
        }
    }

    public float GetCurrentBlockStartPoint()
    {
        return blockGroupsQueue.Peek()[0].transform.position.y;
    }
}
