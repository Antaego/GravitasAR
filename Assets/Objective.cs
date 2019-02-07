using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    public Transform sun;
    public SpaceShip ss;
    public float rotationSpeed = 1.0f;
    public float max_radius = 2.0f;
    public float min_radius = 1.0f;
    private Transform t;
    public GameObject g;

    // Start is called before the first frame update
    void Start()
    {
        //g = GetComponent<GameObject>();
        t = g.transform;
        RandomPos();
    }

    // Update is called once per frame
    void Update()
    {
       t.RotateAround(sun.position,sun.up, rotationSpeed * 10.0f * Time.deltaTime);
    }

    public void RandomPos()
    {
        g.SetActive(true);
        if (t != null)
        {
            t.position = sun.position + new Vector3(Random.Range(min_radius, max_radius), 0, 0);
        }
        
    }

    public void Captured()
    {
        g.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent.name == ss.name)
        {
            Captured();
            ss.SetObjective();
            print("objective captured!");
        }
    }
}
