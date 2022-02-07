using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour
{
    string[] Inimigos = new string[3];

    // Start is called before the first frame update
    void Start()
    {
        Inimigos[0] = "Miller";
        Inimigos[1] = "Mateus";
        Inimigos[2] = "Juninho";

        foreach (string i in Inimigos)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
