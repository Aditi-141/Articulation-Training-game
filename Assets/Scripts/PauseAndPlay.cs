using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseAndPlay : MonoBehaviour {

    protected string scorepause;
    void Start()
    {

    }
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("Scene_GrassRoadRace");
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ToSettings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void ToExit()
    {

    }

}
