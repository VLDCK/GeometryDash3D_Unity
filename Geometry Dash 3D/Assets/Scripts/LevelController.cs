using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{

    //public GameObject[] levels = new GameObject[3];
    
    public void FirstLevel() 
    {
        SceneManager.LoadScene(2);
    }
    public void SecondLevel()
    {
        SceneManager.LoadScene(3);
    }
   
}
