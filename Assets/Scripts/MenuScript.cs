using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public Button start;
    public Button help;
    public Button ex;
    public Button back;
    // Start is called before the first frame update
    public GameObject hPane;

    void Start()
    {
        hPane.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartPressed()
    {
        SceneManager.LoadScene(1);
    }
    public void HelpPressed()
    {
        hPane.SetActive(true);
    }
    public void BackPressed()
    {
        hPane.SetActive(false);
    }
    public void ExitPressed()
    {
        Application.Quit();
    }
}
