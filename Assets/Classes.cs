using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes : MonoBehaviour
{

    [System.Serializable]

    public class Cachorro
    {
        public string raca;
        public int idade;
        public int tamanho;

        public Cachorro(string raca, int idade, int tamanho)
        {
            this.raca = raca;
            this.idade = idade;
            this.tamanho = tamanho;
        }
    }

    public Cachorro Dog;

    private void Start()
    {
        //Debug.Log(Dog.raca);
        //Debug.Log(Dog.idade);
        //Debug.Log(Dog.tamanho);

        Statics.estaticos.AumentarVida();
        Debug.Log("Seu total de vidas é: " + Statics.estaticos.Vidas);
    }


}
