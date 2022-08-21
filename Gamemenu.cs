using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gamemenu : MonoBehaviour
{
	public void MoveToGame()
	{

    SceneManager.LoadScene("MainMenu");

	}

	public void MoveToGameManu()
	{

    SceneManager.LoadScene("GameMenu");

	}

	public void MoveToChapter()
	{
       SceneManager.LoadScene("Chapters");
	}

	public void MoveToVideo()
	{
       SceneManager.LoadScene("Video");
	}

	public void QuitGame()
	{
       Application.Quit();
	}
}