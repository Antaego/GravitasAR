using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public ParticleSystem flame;
    public ParticleSystem explosion;
    public Rigidbody rb;
    public EasyImageTargetBehaviour t_init;
    //initializers
    public float initialThrust = 1.0f;
    public float startingRaidus = 3.0f;
    //ship variables

    public float thrust = 0.5f;
    public float fuel = 20.0f;
    public float burnRate = 0.05f;

    private GameObject ship;
    
    private bool burning = false;
    private bool active = true;
    private bool objective_held = false;
    private bool[] turning = { false, false };
    private Vector3 initialPos;
    private Quaternion initialRot;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(initialThrust, 0, 0);
        initialPos = rb.transform.position;
        initialRot = rb.transform.rotation;
        rb.transform.position = new Vector3(rb.transform.position.x, rb.transform.position.y, startingRaidus);
        ship = transform.gameObject;
        explosion.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        //burning = false;
        //print(rb.velocity.ToString());
        Thrust();
        Turn();
        if (!active)
        {
            rb.gameObject.SetActive(false);
        }
    }

    void FixedUpdate()
    {

    }


    public void Explode()
    {
        ParticleSystem temp = Instantiate(explosion, transform.position, Quaternion.identity);
        temp.Play();
        ship.SetActive(false);
    }
    public void ExtAccel(Vector3 f)
    {
        rb.AddForce(f, ForceMode.Acceleration);
    }
    public void Thrust()
    {
        if (burning)
        {
            if (fuel >= burnRate)
            {
                rb.AddForce(Vector3.Normalize(rb.transform.right) * thrust, ForceMode.Acceleration);
                flame.Play();
                Handheld.Vibrate();
                fuel -= burnRate;
                print("fuel remaining " + fuel);
            }
            else
            {
                print("Out of fuel");
                flame.Stop();
            }
        }
        else
        {
            flame.Stop();
        }


    }



    public void Burning(bool b)
    {
        burning = b;
    }
    public void Turning(bool b, bool dir)
    {
        turning[0]=b;
        turning[1] = dir;
    }


    public void Turn()
    {
        if (turning[0])
        {
            if (turning[1]) {rotateCW();}
            else {rotateCCW();}
        }
    }

    public void SetObjective()
    {
        objective_held = true;
    }

    public void rotateCCW()
    {
        Handheld.Vibrate();
        rb.transform.Rotate(Vector3.up, -10);
    }

    public void rotateCW()
    {
        Handheld.Vibrate();
        rb.transform.Rotate(Vector3.up, 10);
    }

    public bool HasObjective()
    {
        return (objective_held);
    }

    public void ResetVariables()
    {
        objective_held = false;
        transform.SetParent(t_init.transform);
        Handheld.Vibrate();
        rb.velocity = new Vector3(initialThrust, 0, 0);
        rb.transform.position = new Vector3(initialPos.x, initialPos.y, startingRaidus);
        fuel = 20.0f;
        rb.rotation = initialRot;
        rb.angularVelocity = new Vector3(0, 0, 0);
        if (ship != null)
        {
            ship.SetActive(true);
        }
        
    }
}
