using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float CountdownTime;
    public Image CountdownImage;

    public GameObject CountdownScript;
    public GameObject Countdown;
    public GameObject TimerScript;
    // public GameObject TimerBackground;
    public GameObject HighScore;
    // public GameObject CrossHair;

    public Sprite TWO, ONE, GO;

    private void Start()
    {
        TimerScript.SetActive(false);
        // CrossHair.SetActive(true);
        HighScore.SetActive(false);
        // TimerBackground.SetActive(false);
        // TWO = Resources.Load<Sprite>("Textures/NewUIAssets/TWO");
        // ONE = Resources.Load<Sprite>("Textures/NewUIAssets/ONE");
        // GO = Resources.Load<Sprite>("Textures/NewUIAssets/GO");

    }

    private void Update()
    {
        RectTransform CountDownTransform = CountdownImage.GetComponent<RectTransform>();

        CountdownTime-= Time.deltaTime;
        // UpdateCountdown(CountdownTime.ToString("F0"));

        if (CountdownTime > 3F)
        {
            // pass
        }
        else if (CountdownTime.ToString("F0") == "3")
        {
            CountdownImage.GetComponent<Image>().overrideSprite = TWO;
            CountDownTransform.sizeDelta = new Vector2 (300, 300);
        }
        else if (CountdownTime.ToString("F0") == "2")
        {
            CountdownImage.GetComponent<Image>().overrideSprite = ONE;
            CountDownTransform.sizeDelta = new Vector2 (200, 200);
        }
        else
        {
            CountdownImage.GetComponent<Image>().overrideSprite = GO;
            CountDownTransform.sizeDelta = new Vector2 (150, 150);
        }

        if (CountdownTime<= 0)
        {
            CountdownScript.SetActive(false);
            Countdown.SetActive(false);
            TimerScript.SetActive(true);
            // CrossHair.SetActive(true);
            // TimerBackground.SetActive(true);
        }
    }

    // void UpdateCountdown(string txt)
    // {
    //     CountdownText.text = (txt);
    // }
}
