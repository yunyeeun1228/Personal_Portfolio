using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour

{
    public GameObject Tool_tutorial;
    public bool Paused;

    void Start()
    {
        Tool_tutorial.SetActive(true);
    }

    void Update()
    {
        if(Paused) 
            Continue();
        else
            Pause();

    }
        
    public void Pause() {
        Tool_tutorial.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue() {
        Tool_tutorial.SetActive(false);
        Time.timeScale = 1;
    }
    
}
