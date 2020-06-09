using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ToGame()
    {
        SceneManager.LoadScene("Scene_GrassRoadRace");
    }
    public void ToInstruction()
    {
        SceneManager.LoadScene("Instruction");
    }
    public void ToSettings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void ToExit()
    {
       
    }
}
