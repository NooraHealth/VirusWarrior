using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountSprite : MonoBehaviour
{
    public float timeLeft = 3.0f;
    public GameObject one;
    public GameObject two;
    public GameObject three;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft == 3)
        {
            one.SetActive(false);
            two.SetActive(false);
            three.SetActive(true);
        }
        if (timeLeft == 2)
        {
            one.SetActive(false);
            two.SetActive(true);
            three.SetActive(false);
        }
        if (timeLeft == 1)
        {
            one.SetActive(true);
            two.SetActive(false);
            three.SetActive(false);
        }
    }
}
