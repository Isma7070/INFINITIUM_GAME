using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * 100f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
