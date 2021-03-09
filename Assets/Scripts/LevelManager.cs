using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

	public float autoLoadLevelTime;

    void Start()
    {
		if(autoLoadLevelTime == 0)
		{
			Debug.Log ("Level auto load disabled.");
		}
		else
		{
			Invoke ("LoadNextLevel", autoLoadLevelTime);
		}
	}

	public void LoadLevel(string name)
	{
		Debug.Log ("New Level Load : " + name);
		// SceneManager.LoadScene (name);
		StartCoroutine(LoadSceneAsync(name));
	}

	public void QuitRequest ()
	{
		Debug.Log ("Quit Requested!");
		Application.Quit ();
	}

	public void LoadNextLevel ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}

	IEnumerator LoadSceneAsync(string sceneToLoad)
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneToLoad);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
