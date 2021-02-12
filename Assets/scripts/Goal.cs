using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
	public GameObject finishPanel;

   void OnTriggerEnter2D (Collider2D colInfo)
	{
		
			Debug.Log("GAME WON! :D");
			finishPanel.SetActive(true);
      		Time.timeScale = 0f;
		
	}

	public void MiamiLevel()
  {
      SceneManager.LoadScene("Miami");
      Time.timeScale = 1f;
  }
  public void NewYorkLevel()
  {
      SceneManager.LoadScene("NewYork");
      Time.timeScale = 1f;
  }
  public void GrandCanyonLevel()
  {
      SceneManager.LoadScene("GrandCanyon");
      Time.timeScale = 1f;
  }
  public void DaytonaLevel()
  {
      SceneManager.LoadScene("Daytona");
      Time.timeScale = 1f;
  }
  public void BackRoadsLevel()
  {
      SceneManager.LoadScene("BackRoads");
      Time.timeScale = 1f;
  }

  public void QuitGame()
  {
      SceneManager.LoadScene("Main Menu");
	  Time.timeScale = 1f;
  }

  public void RestartGame()
  {
      Application.LoadLevel(Application.loadedLevel);
      Time.timeScale = 1f;
  }
}
