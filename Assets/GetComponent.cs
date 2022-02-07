using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponent : MonoBehaviour
{

    private Rigidbody rig;
    private BoxCollider box;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        box = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
