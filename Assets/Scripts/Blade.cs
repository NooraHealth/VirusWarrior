using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    bool isCutting = true;
    Rigidbody rb;
    Camera cam;
    public GameObject bladeTrailPrefab;
    private GameObject currentBladeTrail;
    Vector3 previousPosition;
    public float minCuttingVelocity = 0.001f;
    // CircleCollider circleCollider;
    BoxCollider boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
        boxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCut();
        }
       else if (Input.GetMouseButtonUp(0))
        {
            StopCut();
        }
        if (isCutting)
        {
            UpdateCut();
        }
    }

    void UpdateCut()
    {
        Vector3 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        rb.position = newPosition;

        float velocity = (newPosition - previousPosition).magnitude * Time.deltaTime;
        if(velocity > minCuttingVelocity)
        {
            boxCollider.enabled = true;
        } else
        {
            boxCollider.enabled = false;
        }
        previousPosition = newPosition;

    }

    void StartCut()
    {
        isCutting = true;
        currentBladeTrail = Instantiate(bladeTrailPrefab, transform);
        boxCollider.enabled = false;
    }

    void StopCut()
    { 
        isCutting = false;
        currentBladeTrail.transform.SetParent(null);
        Destroy(currentBladeTrail, 2.0f);
        boxCollider.enabled = false;
    }
    private void OnTriggerEnter(Collider other) {
        
        Debug.Log("something destroyed");
        Destroy(gameObject);       
    }
}
