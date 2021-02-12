using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 5f;
    public float timeLeft;
    public GameObject timesUpPanel;

    // Start is called before the first frame update
    void Start()
    {
        timesUpPanel.SetActive(false);
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
        Time.timeScale = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
            
        }
        else
        {
    
            timesUpPanel.SetActive(true);
            Time.timeScale = 0;
            
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
