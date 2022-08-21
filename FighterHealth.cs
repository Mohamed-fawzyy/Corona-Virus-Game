using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FighterHealth : MonoBehaviour
{

	 public int maxHealth = 4 ;  
     public int currentHealth;
     public HealthBar healthBar;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; 
	    // healthBar.SetMaxHealth(maxHealth);
    }
   
    // Update is called once per frame
    void Update()
    {
        //youLose.text = "";

        /*if (Input.GetKeyDown(KeyCode.Space))
    
     {
        TakeDamage(1);
     }*/

    }

      void TakeDamage(int damage)
        {
        	currentHealth -= damage;
        	healthBar.SetHealth(currentHealth);
        }

       /* void OnCollisionEnter(Collision collision)
        {

            if (collision.gameObject.tag == "Corona")
            {
                TakeDamage(1);
            }
        }*/
      
      void OnTriggerEnter(Collider other)
      {
      	if (other.gameObject.CompareTag("Corona"))
      	{
      		TakeDamage(1);
      		//SceneManager.LoadScene("MainMenu");
      	}

      	if ( currentHealth == 0)
      	{
      		SceneManager.LoadScene("GameOver");
      	}

      }
}
