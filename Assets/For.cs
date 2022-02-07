using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For : MonoBehaviour
{
    public int n1;
    public int n2;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < n1; i++)
        {
            Debug.Log($"Valor de {i}");
        }

        //for (int i = 0; i < n2; i--)
        //{
        //    Debug.Log($"Valor de {i}");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
