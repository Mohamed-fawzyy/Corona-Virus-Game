using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    
     public Slider slider;
     public Image BlueFill;
     public Gradient gradient;
     
     
     public void SetMaxhealth(int health) // public
     {
        slider.maxValue = health;
        slider.value = health;
        BlueFill.color = gradient.Evaluate(1f);
     }

     public void SetHealth(int health)
     {
     	slider.value = health;
        BlueFill.color = gradient.Evaluate(slider.normalizedValue);
     }

}  