using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class EndGoal : MonoBehaviour
{
    public SpaceShip ss;
    public GameObject station;
    public GameObject mainPanel;
    public GameObject winPanel;
    public GameObject losePanel;
    public GameObject musicEmitter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.name == "Capsule")
        {

            if (ss.HasObjective())
            {
                mainPanel.SetActive(false);
                winPanel.SetActive(true);
                musicEmitter.GetComponent<AudioSource>().Stop();
            }
            else
            {
                mainPanel.SetActive(false);
                losePanel.SetActive(true);
                musicEmitter.GetComponent<AudioSource>().Stop();
            }
        }
    }
}
