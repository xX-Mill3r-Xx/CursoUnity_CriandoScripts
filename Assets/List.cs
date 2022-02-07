using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    [System.Serializable]
    public class Inimigo
    {
        public string nome;
        public double velocidade;
        public int dano;

        public Inimigo(string nome, double velocidade, int dano)
        {
            this.nome = nome;
            this.velocidade = velocidade;
            this.dano = dano;
        }
    }

    public List<Inimigo> enemy = new List<Inimigo>();

    private void Start()
    {
        enemy.Add(new Inimigo("X",10.0,10));
        enemy.Add(new Inimigo("Y",20.0,20));
    }
}
