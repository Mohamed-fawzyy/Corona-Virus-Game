using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCircle : MonoBehaviour
{
     void OnTriggerEnter(Collider other)
   {
     Destroy(gameObject);
   }
}
