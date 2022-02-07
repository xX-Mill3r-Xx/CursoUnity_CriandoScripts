using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhile : MonoBehaviour
{
    //public int n1;

    public int dinheiro;
    // Start is called before the first frame update
    void Start()
    {
        //while (n1 > 10)
        //{
        //    Debug.Log("Congratulations");
        //    n1--;
        //}

        do
        {
            Debug.Log($"O seu dinheir é {dinheiro}");
            dinheiro -= 50;
        } while (dinheiro < 1000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
