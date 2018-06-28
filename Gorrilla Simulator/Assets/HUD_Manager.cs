using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUD_Manager : MonoBehaviour {

    public int StartingHealth;
    int CurrentHealth;

    int score;
    public Text scoretext;
    public Slider healthbar;

    // Use this for initialization
    void Start() {
        score = 0;
        scoretext.text = "Score: " + score;
        CurrentHealth = StartingHealth;
        healthbar.value = CurrentHealth;
    }


    public void UpdateScore(int amount)
    {
        score = score + amount;
        scoretext.text = "Score: " + score;
    }

    public void UpdateHealth(int amount)
    {
        CurrentHealth = CurrentHealth + amount;
        healthbar.value = CurrentHealth;
        if (CurrentHealth <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        SceneManager.LoadScene("Gorrilla Simulator");
    }
}