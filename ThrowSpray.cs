using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ThrowSpray : MonoBehaviour
{
    
    /*public float throwForce = 200f;
    public GameObject sprayPrefab;
    public Text AllSpraysCollected;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
        	Throwspray();
        } 
    }
    void Throwspray()
    {
        GameObject spray = Instantiate(sprayPrefab, transform.position, transform.rotation);
        Rigidbody rb = spray.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
    }*/


    /*public float throwForce = 200f;
    private Transform playerCam;
    private Transform player;
    //public GameObject sprayPrefab;
    bool hasPlayer = false;
    bool beingCarried = false;
    private bool touched = false;
    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, player.position);

        if( distance <= 2.5f)
        {
             hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }

        if (hasPlayer && Input.GetButtonDown("use"))//mouse
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            beingCarried = true;
        }
        if (beingCarried)
        {
            if (touched)
            {
                GetComponent<Rigidbody>().isKinematic = true;
                beingCarried = false;
                transform.parent = null;
                touched = false;
            }
            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                beingCarried = false;
                GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
            }
            else if (Input.GetMouseButtonDown(1))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
            }
        }
    }

    void OnTriggerEnter()
    {
        if (beingCarried)
        {
            touched = true;
        }
    }*/

    public float delay = 3;
    public GameObject explosionEffect;
    public float radius = 5f;
    public float force = 700f;
    public GameObject scoreText;
    public static int theScore;
    private float count;
    
    float countDown;
    bool hasExploded = false;

    void Start()
    {
        countDown = delay;
    }

    void Update()
    {
        countDown -= Time.deltaTime;
        if (countDown <= 0f && !hasExploded)
        {
            Exploded();
            hasExploded = true;
        }
/////////////////////////////////////////////////////
     scoreText.GetComponent<Text>().text = "Corona died " + theScore;
     
     if (ThrowSpray.theScore == 5)
    {
        //Debug.Log("Yarb");
        SceneManager.LoadScene("GameWin");
     }
     ////////////////////////////////////////////////////
   }
    
    void Exploded()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        
        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if ( rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius);

            }
            
           CoronaCollider dest =  nearbyObject.GetComponent<CoronaCollider>();
           if ( dest != null)
           {
              dest.Destroy();
           }
        }
         
        Collider[] collidersToMove = Physics.OverlapSphere(transform.position, radius);
         
        foreach (Collider nearbyObject in collidersToMove)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if ( rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius);

            }
        } 
        Destroy(gameObject);
    }

     void OnTriggerEnter(Collider other)
      {
        if (other.gameObject.CompareTag("Corona"))
        {
            ThrowSpray.theScore += 1;
            /*if (count == 1)
            {
                Debug.Log("you win");
            }*/
            // Debug.Log("you win");
        }
    }    
}

















