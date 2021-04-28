using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject levelPickMenu;
    public void FirstLevel() 
    {
        SceneManager.LoadScene(1);
    }
    public void SecondLevel()
    {
        SceneManager.LoadScene(2);
    }
    public void ExitToMenu()
    {
        levelPickMenu.SetActive(false);
        mainMenu.SetActive(true);
        Score.CountOfDying = 1;
    }
}
