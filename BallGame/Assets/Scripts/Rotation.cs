using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float RatationSpeed1;
    public float RatationSpeed2;
    public float RatationSpeed3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RatationSpeed1 * Time.deltaTime, RatationSpeed2 * Time.deltaTime, RatationSpeed3 * Time.deltaTime, Space.World);
    }
}
