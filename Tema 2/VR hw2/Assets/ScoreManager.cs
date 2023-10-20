using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText; 

    public void IncreaseScore()
    {
        
        score += 1;

        scoreText.text = "Your Score: " + score.ToString();
        Debug.Log(score);
    }
    
}
