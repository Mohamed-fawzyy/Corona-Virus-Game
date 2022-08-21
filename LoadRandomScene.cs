using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRandomScene : MonoBehaviour
{
	public void LoadRandomScenes()
	{
        int index = Random.Range(2,11); // index of question
        SceneManager.LoadScene(index);
    }
}
