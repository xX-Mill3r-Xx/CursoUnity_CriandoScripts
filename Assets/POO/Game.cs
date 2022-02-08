using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player1 player = new Player1();
        player.Experience = 10;
        Debug.Log(player.Experience);
    }
}
