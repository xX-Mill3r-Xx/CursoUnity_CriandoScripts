using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodo : MonoBehaviour
{
    public int Vida;

    public int Life;
    public int Dano;

    // Start is called before the first frame update
    void Start()
    {
        AumentarVida(Life);
        DiminuirVida(Dano);
        Debug.Log($"O valor da vida é {Vida}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AumentarVida(int life)
    {
        Vida += life;
    }

    void DiminuirVida(int dano)
    {
        Vida -= dano;
    }
}
