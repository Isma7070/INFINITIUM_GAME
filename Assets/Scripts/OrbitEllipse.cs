using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class OrbitEllipse : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float a;
    [SerializeField] float b;
    [SerializeField] float c;
    [SerializeField] float alpha;
    [SerializeField] float deltaAlpha;
    [SerializeField] Vector3 center;
    [SerializeField] Transform focus1;
    [SerializeField] float G;
    [SerializeField] float M;
    float r;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        center = new Vector3(focus1.position.x + c, 800f, focus1.position.z);

        r = Vector3.Distance(focus1.position, transform.position);

        transform.position = new Vector3(center.x + a * Mathf.Cos(alpha), 800f, center.z + b * Mathf.Sin(alpha));
        c = Mathf.Sqrt(a*a - b*b);

        deltaAlpha = (Mathf.Sqrt(2 * G * M * (1 / r - 1 / (2 * a))) * 180 * Time.deltaTime) / (Mathf.PI * Mathf.Sqrt(Mathf.Abs((a * a + b * b) / 2)));
        alpha += deltaAlpha;
    }
}
