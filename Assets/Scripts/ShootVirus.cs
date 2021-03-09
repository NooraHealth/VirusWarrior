using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootVirus : MonoBehaviour
{

    public GameObject SlashAnim;
    public GameObject SquishSound;
    public GameObject redDestroyedAnim;
    // public GameObject purpleDestroyedAnim;
    public GameObject MainCamera;
    // public AudioSource OnCoronaDestroy;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                var rig = hitInfo.collider.GetComponent<Rigidbody>();
                if (rig != null)
                {
                    // Play slice Animation
                    Vector3 getPos = rig.position;
                    var ani = Instantiate(SlashAnim, getPos, Quaternion.identity) as GameObject;
                    var squish = Instantiate(SquishSound, getPos, Quaternion.identity) as GameObject;

                    Destroy(rig.gameObject);
                    Destroy(ani.gameObject, .5F);
                    Destroy(squish.gameObject, .7F);
                
                    if(PlayerPrefs.GetInt("SOUND") == 1)
                    {
                        ani.GetComponent<AudioSource>().Play();
                        squish.GetComponent<AudioSource>().PlayDelayed(.3F);
                    }
                    //Destroy Anim
                    // StartCoroutine(waitSeconds(.3f));

                    // Update Score
                    if (rig.gameObject.tag == "Enemy")
                    {
                        ScoreScript.scoreValue += 1;
                        
                        var redDes = Instantiate(redDestroyedAnim, getPos, Quaternion.identity) as GameObject;
                        Destroy(redDes.gameObject, .4F);
                    }
                    if (rig.gameObject.tag == "EnemyBoss")
                    {
                        ScoreScript.scoreValue += 3;
                    }
                }

            }
        }
    }

    IEnumerator waitSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
}
