using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Managers.Game.SetState(typeof(GamePlayState));
    }


}
