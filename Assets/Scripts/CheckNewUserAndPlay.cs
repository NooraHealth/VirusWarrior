using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckNewUserAndPlay : MonoBehaviour
{
    public GameObject[] ToDeactivate;
    public GameObject ToActivate;

    public void LoadLevel(string name)
    {
        if (PlayerPrefs.GetInt("U_TUTORIAL") == 1)
        {
            for (int i = 0; i < ToDeactivate.Length;i++)
            {
                ToDeactivate[i].SetActive(false);
            }
            ToActivate.SetActive(true);
            PlayerPrefs.SetInt("U_TUTORIAL", 0);
        }
        else
        {
            Debug.Log("New Level Load : " + name);
            SceneManager.LoadScene(name);
        }
    }
}
