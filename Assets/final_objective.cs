using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final_objective : MonoBehaviour
{
    public float rotationspeed = 10.0f;
    public float orbitspeed = 10;
    public MassiveBody mb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, transform.up, rotationspeed * Time.deltaTime);
        transform.RotateAround(mb.transform.position, Vector3.up, orbitspeed * Time.deltaTime);
    }
}
