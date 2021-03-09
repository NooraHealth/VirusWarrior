using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRandom : MonoBehaviour
{
    // float timeVar = 0;
    // float rotationRange = 2;
    // Update is called once per frame
    void Update()
    {

        // Vector3 randomDirection = new Vector3(Mathf.Sin(timeVar), Mathf.Sin(timeVar), Mathf.Sin(timeVar));

        //transform.Translate(Vector3.up * Time.deltaTime * 1.0f);
        Vector3 position = new Vector3(Random.Range(-5F, 5F), Random.Range(-5F, 5F), Random.Range(-1F, 1F));
        // transform.Translate(randomDirection * Time.deltaTime * 0.1F);
        transform.Translate(position * Time.deltaTime * 0.1F);
    }
}
