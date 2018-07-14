using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardController : MonoBehaviour {

    public static ScoreBoardController instance;

    public Text playerHealthText;
    public Text scoreCounterText;
    public Slider healthSlider;

    public static int playerHealth = 100;
    public static int scoreCounter = 0;

    // Use this for initialization
    void Start () {
        instance = this;
        //playerHealthText.text = playerHealth.ToString();
        scoreCounterText.text = scoreCounter.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void UpdateHealth(int health)
    {
        healthSlider.value = health;
    }
    //public void PlayerHealthDecrease()
    //{
    //    playerHealth -= 20;
    //    playerHealthText.text = playerHealth.ToString();
    //}

    public void ScoreCounterIncrease()
    {
        scoreCounter += 10;
        scoreCounterText.text = scoreCounter.ToString();
    }
}
