using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timerTime;
    public Text timerText;
    public GameObject TimerScript;
    public GameObject TimerBackground;
    public GameObject SpawnScript;
    public GameObject ShootScript;
    // public GameObject FireButton;
    public GameObject ScoreboardPanel;
    public GameObject AltScoreboardPanel;
    
    // public GameObject Crosshair;

    private void Start() 
    {
        timerText.text = "60";
    }
    
    private void Update()
    {
        if (timerTime > 0)
        {
            timerTime -= Time.deltaTime;
            UpdateTimer(timerTime.ToString("F0"));
        }
        else
        {
            UpdateTimer("0");
            OnTimerEnd();
        }
    }

    void UpdateTimer(string txt)
    {
        timerText.text =(txt);      
    }

    void OnTimerEnd()
    {
        TimerScript.SetActive(false);
        SpawnScript.SetActive(false);
        ShootScript.SetActive(false);

        // Crosshair.SetActive(false);
        // FireButton.SetActive(false);

        if(ScoreScript.scoreValue <= 10)
        {
            AltScoreboardPanel.SetActive(true);
        }
        else
        {
            ScoreboardPanel.SetActive(true);
        }
    }

}
