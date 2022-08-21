using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoronaCollider : MonoBehaviour
{
       
    private Rigidbody rb;
    public GameObject destroyedVersion;
    public AudioSource collectSound;

    public void Destroy()
    {
    	Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }

   void Strat()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
  
   {
      collectSound.Play(); 
       Destroy(gameObject);
   }
}
