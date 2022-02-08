using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRotation : MonoBehaviour
{
    public float Velocidade;
    public float Rotacao;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Velocidade * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Velocidade * Time.deltaTime);
            
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(-Vector3.up * Rotacao * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Velocidade * Time.deltaTime);
            
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * Rotacao * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * Velocidade * Time.deltaTime);
        }
    }
}
