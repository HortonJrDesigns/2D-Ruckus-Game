using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
	public GameObject crashPanel;

    void OnTriggerEnter2D (Collider2D colInfo)
	{
        if(colInfo.CompareTag("Ground"))
        {
			Debug.Log("CRASHED! :D");
            crashPanel.SetActive(true);
      		Time.timeScale = 0f;
        }
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
