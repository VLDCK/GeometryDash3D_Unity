using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject scorePanel;
    public GameObject pausePanel;
    
    public GameObject pauseMenuButtons;
    public AudioSource music;
   
    bool isPaused = false;

    void Update()
    {
        PauseControl();
    }
    public void PauseControl()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        { 
            if (!isPaused)
                PauseEnter();
            else
                PauseExit();
        } 
    }
    void PauseEnter()
    {
        music.Pause();
        pausePanel.SetActive(true);
        scorePanel.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void PauseExit() 
    {
        music.Play();
        pausePanel.SetActive(false);
        scorePanel.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void ExitToMenu()
    {
       
        SceneManager.LoadScene(0);
        Score.CountOfDying = 1;
        Time.timeScale = 1f;
    }
    public void Exit()
    {
        Application.Quit();
    }

}

