using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowForce : MonoBehaviour
{
    public float throwForce = 40f;
    public GameObject sprayPrefabs;

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetMouseButtonDown(0))
        {
        	ThrowSpray();
        }
    }

    void ThrowSpray()
    {
       GameObject spray = Instantiate(sprayPrefabs, transform.position, transform.rotation);
      Rigidbody rb = spray.GetComponent<Rigidbody>();
      rb.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
    }
    void OnTriggerEnter(Collider other)
   {
   	 //ScoreSystem.theScore += 1;
     Destroy(gameObject);
   }
}
