using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollectorScript : MonoBehaviour
{
    
    public Text scoreText;
    private int score = 0;

    public void IncreaseScore()
    {
        score++;

        scoreText.text = "Score: " + score;
    }


    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomb")
        {
            IncreaseScore();

            target.gameObject.SetActive(false);

        }
    }
    
}
