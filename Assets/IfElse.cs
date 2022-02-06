using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour
{
    public int n1;
    public int n2;

    public bool Valor;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Valor);

        if (Valor)
        {
            Debug.Log("Verdadeiro");
            Debug.Log(n1 + n2);
        }
        else
        {
            Debug.Log("Falso");
            Debug.Log(n1 - n2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
