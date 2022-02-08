using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumScript : MonoBehaviour
{
    public enum Direcoes
    {
        Norte,
        Sul,
        Leste,
        Oeste
    }

    public Direcoes MinhaDirecao;

    // Start is called before the first frame update
    void Start()
    {
        switch (MinhaDirecao)
        {
            case Direcoes.Norte:
                DirecaoSelecionada("Voce selecionou o norte");
                break;

            case Direcoes.Sul:
                DirecaoSelecionada("Voce selecionou o sul");
                break;

            case Direcoes.Leste:
                DirecaoSelecionada("Voce selecionou o leste");
                break;

            case Direcoes.Oeste:
                DirecaoSelecionada("Voce selecionou o oeste");
                break;

            default:
                Debug.Log("Selecione uma direçao");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DirecaoSelecionada(string texto)
    {
        Debug.Log(texto);
    }
}
