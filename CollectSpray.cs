using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSpray : MonoBehaviour
{
	public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
   {
   	 collectSound.Play(); 
   	 ScoreSystem.theScore += 1;
     Destroy(gameObject);
   }
}
