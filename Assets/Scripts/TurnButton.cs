using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TurnButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public SpaceShip ss;
    public bool direction;
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
        if (direction) {ss.Turning(true, false);}
        else {ss.Turning(true, true);}
        
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        ss.Turning(false, false);
    }
}
