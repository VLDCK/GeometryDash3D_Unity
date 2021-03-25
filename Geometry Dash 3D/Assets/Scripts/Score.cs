using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text textDeadScore;
    public GameManager gameManager;
    private string defaultString = "Quantity of dying: "; 
    void Update()
    {
        textDeadScore.text = defaultString + gameManager.CountOfDying.ToString();
    }
}
