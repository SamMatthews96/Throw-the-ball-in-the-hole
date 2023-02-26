using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;

    

    public void IncreaseScore(int delta)
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }
}
