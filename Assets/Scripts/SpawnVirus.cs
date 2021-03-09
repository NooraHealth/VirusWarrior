using UnityEngine;
using System.Collections.Generic;
 
public class SpawnVirus : MonoBehaviour
{
    public float playerHealth;       // Reference to the player's heatlh.
    public Transform player;            // The position that that camera will be following.
    public GameObject enemy;                // The enemy prefab to be spawned.
    public float spawnTime = 3f;            // How long between each spawn.
    public float spawnDistance = 10;
    public float score = 0f;
    public float spawnscore = 100f;
    public float maxspawnscore = 100f;
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
    private float nextSpawn = 0;
 
    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        nextSpawn = Time.time + spawnTime;
        Debug.Log("I reached this point 1");
    }
   
    void Update(){
        if(Time.time >= nextSpawn){
            Spawn();
            nextSpawn += spawnTime;
        }
    }
 
    void Spawn(int count = 1)
    {
        // If the player has no health left...
        if (playerHealth <= 0f)
        {
            // ... exit the function.
            return;
        }
 
        if (score < spawnscore)
        {
            return;
        }
 
        if (score >= maxspawnscore)
        {
            return;
        }
 
        // collect the children that are close.
        List<Transform> near = new List<Transform>();
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform spawnPoint = transform.GetChild(i);
            if (Vector3.Distance(player.transform.position, spawnPoint.position) <= spawnDistance)
            {
                near.Add(spawnPoint);
            }
            Debug.Log("I reached this point 2");
            Debug.Log(near.Count);
        }
 
 
        if (near.Count > 0)
        {
            // create a new list here.... same as line 29, but call the variable something else.
            List<Transform> pointsToSpawn = new List<Transform>();
 
            // loop from 0 to <count here..... same as line 30 in the code you just had. {
            // make sure you include the below lines....
            for (int i = 0; i < count; i++)
            {
                // Find a random index between zero and one less than the number of spawn points.
                int spawnPointIndex = Random.Range(0, near.Count);
 
                // add near[spawnPointIndex] to the new list // same as line 35
                pointsToSpawn.Add(near[spawnPointIndex]);
 
                // remove spawnPointIndex from near // new line: near.RemoveAt(spawnPointIndex);
                near.RemoveAt(spawnPointIndex);
 
                // if we dont have any more points. break... // new line: Break;
                if (near.Count == 0) break;
                Debug.Log("I reached this point 3");
                Debug.Log(near.Count);
                // end the loop... }
            }
 
            // loop through each of your new variable.... new line: foreach(Transform spawnPoint in newVariableName){
            foreach (Transform spawnPoint in pointsToSpawn)
            {
                // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
                Debug.Log("I reached this point 4");
                Debug.Log(near.Count);
                GameObject instance = (GameObject)Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
                instance.transform.Rotate(Vector3.up, Random.Range(0f, 360f));
                Debug.Log("I reached this point 5");
                Debug.Log(near.Count);
            }
        }
    }
}
 