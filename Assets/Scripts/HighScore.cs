using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text ScoreValue;
    public Text HighScoreValue;

    // Start is called before the first frame update
    void Start()
    {
        HighScoreValue.text = ScoreValue.text;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
