using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSound : MonoBehaviour
{
    public Image SoundToggleButton;
    public Sprite SOUND_ON, SOUND_OFF;
    public GameObject BgMusic;

    // Update is called once per frame
    void Update()
    {
        RectTransform CountDownTransform = SoundToggleButton.GetComponent<RectTransform>();
        int flag = PlayerPrefs.GetInt("SOUND");

        if (flag == 0)
        {
            SoundToggleButton.GetComponent<Image>().overrideSprite = SOUND_OFF;
            BgMusic.SetActive(false);
        }
        else
        {
            SoundToggleButton.GetComponent<Image>().overrideSprite = SOUND_ON;
            BgMusic.SetActive(true);
        }
    }

    public void ToggleSoundState()
    {
        int flag = PlayerPrefs.GetInt("SOUND");
        if(flag == 0)
        {
            PlayerPrefs.SetInt("SOUND", 1);
            Debug.Log("Sound ON!");
        }
        else
        {
            PlayerPrefs.SetInt("SOUND", 0);
            Debug.Log("Sound OFF!");
        }
    }
}
