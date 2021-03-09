using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirection : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        int direction = (int) Random.Range(1F, 3.1F);

        if (direction == 1)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 0.1f);
        }
        else if(direction == 2)
        {
            transform.Translate(Vector3.back * Time.deltaTime * 0.1f);
        }
        else
        {
            transform.Translate(Vector3.right * Time.deltaTime * 0.1f);
        }
        //transform.Translate(Vector3.up * Time.deltaTime * 1.5f);
    }
}
