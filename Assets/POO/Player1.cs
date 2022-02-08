using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    private int Exp;

    public int Experience
    {
        //Retorna o valor
        get
        {
            return Exp;
        }

        //Atribui o valor
        set
        {
            Exp = value;
        }
    }

    public int Life
    {
        get
        {
            return Exp / 10;
        }
        set
        {
            Exp = value * 10;
        }
    }
}
