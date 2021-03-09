using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveHighScore : MonoBehaviour
{
    int highScore = PlayerPrefs.GetInt("U_SCORE");
    
    void Update()
    {
        var currentScore = ScoreScript.scoreValue;

        if (currentScore > highScore)
        {
            PlayerPrefs.SetInt("U_SCORE", currentScore);
        }
    }
}
