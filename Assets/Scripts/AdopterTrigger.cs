using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdopterTrigger : MonoBehaviour
{
    public SpaceShip ss;
    public MassiveBody planet;
    public EasyImageTargetBehaviour t;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.parent.name == ss.name)
        {
            if (ss != null && planet != null)
            {
                ss.transform.SetParent(t.transform);
                Vector3 trans1 = ss.transform.position;
                Vector3 trans2 = planet.transform.position;
                trans1.y = trans2.y;
                ss.transform.position = trans1;
            }

        }
    }
}
