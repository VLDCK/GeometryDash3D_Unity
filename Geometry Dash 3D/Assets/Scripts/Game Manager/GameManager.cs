using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource dieSound;
   public void GameOver()
    {
          //  dieSound.Play();
            Score.CountOfDying++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public static void Finish()
    {
        Score.CountOfDying = 1;
        SceneManager.LoadScene(0);
    }
}
