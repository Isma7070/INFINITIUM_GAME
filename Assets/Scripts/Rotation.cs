using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    public float x;
    public float y;
    public float z;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().Rotate(new Vector3(x, y, z) * Time.deltaTime);
    }
}
