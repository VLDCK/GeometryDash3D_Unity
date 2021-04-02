using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject scorePanel;
    public GameObject pausePanel;

    public GameObject pauseMenuButtons;
   

    bool isPaused = false;
    // Update is called once per frame
    void Update()
    {
        PauseControll();
    }

    public void PauseControll()
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
        pausePanel.SetActive(true);
        scorePanel.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void PauseExit() 
    {
        pausePanel.SetActive(false);
        scorePanel.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void ExitToMenu()
    {
       // Debug.Log("its exit to menu");
        SceneManager.LoadScene(0);
        Score.CountOfDying = 1;
        Time.timeScale = 1f;
    }
    public void Exit()
    {
       // Debug.Log("its exit From app");
        Application.Quit();
    }

}

