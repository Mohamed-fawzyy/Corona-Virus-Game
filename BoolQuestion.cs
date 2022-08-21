using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoolQuestion : MonoBehaviour
{
    public void True()
	{

    SceneManager.LoadScene("corona L1");

	}

	public void False()
	{
       SceneManager.LoadScene("MainMenu");
	}
}
