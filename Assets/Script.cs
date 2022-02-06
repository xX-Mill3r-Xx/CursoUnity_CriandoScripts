using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Como declarar variaves em unity

    #region Variaveis Comum da Linguagem C#

    /*Aqui damos alguns exemplos de variaveis comum da linguagem
     C# aplicadas na plataforma Unity*/

    // Variaveis tipo Int
    #region Int
    public int ValorInteiro = 10;
    private int ValorInt;
    #endregion

    // Variaveis tipo Float
    #region Float
    public float NumerosDecimais = 10.5f;
    #endregion

    // Variaveis tipo String
    #region String
    public string Nome = "Miller";
    #endregion

    #endregion

    #region Variaveis Propias da Unity
    public GameObject GameObject;
    public Transform TransformUnity;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        // este metodo é chamado uma vez quando o jogo é inicializado;
        GameObject = gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        // este metodo é chamado a cada frame;
    }
}
