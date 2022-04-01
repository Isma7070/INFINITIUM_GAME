using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilator : MonoBehaviour
{
    float timeCounter = 0f;

    public float speed = 1f;
    public float width = 100f;
    public float height = 100f;

    public float x = 0f;
    public float y = 40f;
    public float z = 0f;

    // Start is called before the first frame update
    void Start()
    {
         x = Mathf.Cos(timeCounter) * width;
         z = Mathf.Sin(timeCounter) * height;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter)*width;
        
        float z = Mathf.Sin(timeCounter)* height;

        GetComponent<Transform>().position = new Vector3(x, y, z);
    }
}
