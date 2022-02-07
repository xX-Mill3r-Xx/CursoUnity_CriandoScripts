using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarGameComponent : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        //obj.SetActive(false);
        //obj.GetComponent<Light>().enabled = false;

        if (obj.activeSelf)
        {
            obj.SetActive(false);
            Debug.Log(obj.activeSelf);
        }
        else
        {
            obj.SetActive(true);
            Debug.Log(obj.activeSelf);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
