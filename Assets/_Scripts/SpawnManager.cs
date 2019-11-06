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


}
