using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScoreOnStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ScoreScript.scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
