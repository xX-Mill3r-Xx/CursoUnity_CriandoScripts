using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float SpawTime = 5f;

    public List<GameObject> paredes = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float tempoCont;
    // Update is called once per frame
    void Update()
    {
        tempoCont += Time.deltaTime;

        if(tempoCont >= SpawTime)
        {
            Instantiate(paredes[Random.Range(0,paredes.Count)], transform.position, transform.rotation);

            tempoCont = 0f;

        }
    }
}
