using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Block[] allBlocks;
    private void Start()
    {
        BlockGroup blockGroup = new BlockGroup(5);
        var blocks = blockGroup.GenerateBlockGroup();

        // foreach (var block in blocks)
        // {
        //     Instantiate(block.gameObject);
        // }

    }

    public void PlaceBlock(Block block, Vector3 pos)
    {

        var newBlock = Instantiate(block.gameObject, pos, block.transform.rotation);
        //  newBlock.gameObject.GetComponentInChildren<Rigidbody2D>().isKinematic = true;
    }
}
