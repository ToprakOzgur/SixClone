using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Block[] allBlocks;
    public static SpawnManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        BlockGroup blockGroup = new BlockGroup(4);
        var blocks = blockGroup.GenerateBlockGroup();

        // foreach (var block in blocks)
        // {
        //     Instantiate(block.gameObject);
        // }

    }

    public void PlaceBlock(Block block, Vector3 pos)
    {

        var newBlock = Instantiate(block.gameObject, pos, Quaternion.identity);
        newBlock.gameObject.GetComponentInChildren<Rigidbody2D>().isKinematic = true;
    }
}
