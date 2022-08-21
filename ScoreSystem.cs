using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{

   public GameObject scoreText;
   public static int theScore;
   public Text AllSpraysCollected;

   void Update()
   {
   
	 AllSpraysCollected.text = "";

   	 scoreText.GetComponent<Text>().text = "Sprays Counter: " + theScore;
     
     if (ScoreSystem.theScore == 6)
     {
        AllSpraysCollected.text = "All Sprays Collected";
     }
   }
}
