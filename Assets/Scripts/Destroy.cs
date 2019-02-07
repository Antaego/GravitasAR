using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    GameObject s;
    // Start is called before the first frame update
    void Start()
    {
        s = GetComponent<GameObject>();
        Destroy(s, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
