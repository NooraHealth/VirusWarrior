using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginResult : MonoBehaviour
{

    public Text LoginResultText;
    void Start()
    {
        var userName = PlayerPrefs.GetString("U_NAME");
        LoginResultText.text = "Hi, " + userName + "!";
        Debug.LogFormat("Successfully signed in as {0}", userName);

        PlayerPrefs.SetInt("SOUND", 1);
    }
}