using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int CountOfDying { get; set; } = 0;
    
    public void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {       
            Debug.Log("Its pressed escape");
        }
    }
    public void GameOver() 
    {
        CountOfDying++;
    }
}
