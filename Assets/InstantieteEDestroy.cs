using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantieteEDestroy : MonoBehaviour
{
    public GameObject preFabs;
    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(preFabs, new Vector3(0,0,0), Quaternion.identity);
        }


    }
}
