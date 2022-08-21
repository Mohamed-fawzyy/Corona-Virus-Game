using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparyRotation : MonoBehaviour
{
	/*[SerializeField] Vector3 MovementVector=new Quaternion.Euler(10f,10f,10f);
    [Range(0,1)][SerializeField] float movmentFactor;    
    [SerializeField] float period = 2f;
    Vector3 startingPos;*/

    
    void Update()
    {
        transform.Rotate( Vector3.up * 10 * Time.deltaTime, Space.World);
        
    }
}
