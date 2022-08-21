using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
	public void PlayGame()
	{

    SceneManager.LoadScene("corona L1");

	}

	public void ExitGame()
	{
      SceneManager.LoadScene("GameMenu");
	}
}
