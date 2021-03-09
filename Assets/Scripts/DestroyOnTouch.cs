using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{
    GameObject particle;
  //  public GameObject mainCamera;

 

  void Update ()
      {
          foreach (Touch touch in Input.touches)
          {
              if (touch.phase == TouchPhase.Began)
              {
                //Construct a ray from the current touch coordinates
                  Ray ray = Camera.main.ScreenPointToRay(touch.position);
               if(Physics.Raycast(ray))
                   {
                    /*  if (name == "CoronaVirus(Clone)" ||name == "1CoronaVirus(Clone)" || name == "2CoronaVirus(Clone)")
                      {
                        //ScoreScript.scoreValue += 1;
                          Destroy(gameObject);
                          //Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
                      }   */
                      // Create a particle if hit
                      //nstantiate(particle, transform.position, transform.rotation);
                    Destroy(this.gameObject);
                   }

              }
          }
      }
}
