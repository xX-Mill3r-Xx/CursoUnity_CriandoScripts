using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClasseInimigo : MonoBehaviour
{
    [System.Serializable]
    public class Inimigos
    {
        public string nome;
        public double vida;
        public double poderDeLuta;
        public string especial;

        public Inimigos(string nome, double vida, double poderDeLuta, string especial)
        {
            this.nome = nome;
            this.vida = vida;
            this.poderDeLuta = poderDeLuta;
            this.especial = especial;
        }
    }

    public Inimigos enemy;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"O nome do inimigo é: {enemy.nome}");
        Debug.Log($"O inimigo {enemy.nome} tem vida igual {enemy.vida} pontos");
        Debug.Log($"O poder de luta do inimigo é de {enemy.poderDeLuta}");
        Debug.Log($"O especial deste inimigo é {enemy.especial}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
