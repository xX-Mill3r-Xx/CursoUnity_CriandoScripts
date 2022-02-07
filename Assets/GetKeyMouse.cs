using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Clicou");
    }

    void OnMouseEnter()
    {
        Debug.Log("Mouse em cima do objeto");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Apertou a letra A do teclado");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("Apertou a letra B do teclado");
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            Debug.Log("Apertou a letra C do teclado");
        }
    }
}
