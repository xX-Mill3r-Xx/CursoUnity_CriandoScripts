using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statics : MonoBehaviour
{
    public static Statics estaticos;

    public int Vidas = 3;

    // Start is called before the first frame update
    void Start()
    {
        estaticos = this; 
    }

    public void AumentarVida()
    {
        Debug.Log(Vidas);
    }
}
