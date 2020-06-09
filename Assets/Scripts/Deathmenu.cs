using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Deathmenu : MonoBehaviour {

    public Text scoreText;
    public Image backgroundImg;
    public static int scoreValue = 0;

    private bool isShowned = false;

    private float transition=0.0f;
	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
        if ( !isShowned)
            return;

        transition += Time.deltaTime;
        backgroundImg.color = Color.Lerp(new Color(0, 0, 0, 0), Color.black, transition);

		
	}
    public void Tostop()
    {
        SceneManager.LoadScene("Pause");
        score.scoreValue = 0;
    }

    public void ToggleEndMenu(float score) {
        gameObject.SetActive(true);
        scoreText.text = (scoreValue).ToString();
        isShowned = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Scene_GrassRoadRace");
        score.scoreValue = 0;

    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
