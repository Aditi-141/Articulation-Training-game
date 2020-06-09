using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

   /* private float Score = 0.0f;*/

    private int difficultyLevel = 1;
    private int maxDifficultyLevel = 10;
    private int scoreToNextLevel = 10;
    public static int scoreValue = 0;

    public int value;
   

    private bool isDead = false;

    public Text scoreText;
    public Deathmenu deathmenu;

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {

        if (isDead)
            return;

       if (scoreValue >= scoreToNextLevel)
            LevelUp ();
       /*Score += scoreValue * difficultyLevel;*/
        scoreText.text = (scoreValue).ToString();
        
		
	}

    void LevelUp()
    {
        if (difficultyLevel == maxDifficultyLevel)
            return;

        scoreToNextLevel *= 2;
        difficultyLevel++;

       // GetComponent<Player>().SetSpeed(difficultyLevel);
    }

   public void OnDeath()
    {
        isDead = true;
        PlayerPrefs.SetFloat("HighScore", scoreValue);
        deathmenu.ToggleEndMenu (scoreValue);
    }

   
}
