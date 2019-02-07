using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ThrustButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public SpaceShip ss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ss.Burning(true);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
          ss.Burning(false);
    }
}
