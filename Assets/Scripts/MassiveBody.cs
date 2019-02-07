using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassiveBody : MonoBehaviour
{

    public SpaceShip sp;
    Rigidbody massBody;
    public ParticleSystem explosion;
    public double G = 1.37;
    // Start is called before the first frame update
    void Start()
    {
        massBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        sp.ExtAccel(Gravitate());
    }

    public Vector3 Gravitate()
    {
        float f, m1, m2, r;
       // Vector3 cv = rb.velocity;
        m1 = sp.rb.mass;
        m2 = massBody.mass;
        r = Vector3.Distance(sp.transform.position, massBody.transform.position);
        f = ((float)G * m1 * m2) / Mathf.Pow(r, 2);
        Vector3 forceV = Vector3.Normalize(massBody.transform.position - sp.rb.transform.position) * f * Mathf.Sqrt(Time.deltaTime);
        return (forceV);
    }

    private void OnCollisionEnter(Collision collision)
    {

        print(collision.gameObject.name);
        print(sp.name);
        if (collision.gameObject.name == sp.name)
        {
            sp.Explode();   
        }
        //Destroy(temp, 3.0f);
        //collision.gameObject.SetActive(false);
        
    }
}
