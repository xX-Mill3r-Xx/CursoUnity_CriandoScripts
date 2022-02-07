using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public int DiaSemana;

    // Start is called before the first frame update
    void Start()
    {
        switch (DiaSemana)
        {
            case 1:
                Debug.Log("Domingo");
                break;

            case 2:
                Debug.Log("Segunda");
                break;

            case 3:
                Debug.Log("Terça");
                break;

            case 4:
                Debug.Log("Quarta");
                break;

            case 5:
                Debug.Log("Quinta");
                break;

            case 6:
                Debug.Log("Sexta");
                break;

            case 7:
                Debug.Log("Sabado");
                break;

            default:
                Debug.Log("Fora de data");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
