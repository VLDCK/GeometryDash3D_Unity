using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Класс записів досягнень впродовж ігрового процесу, 
/// та всієї історії для гри
/// </summary>
public class Score : MonoBehaviour
{
    public Text textDeadScore;
    static public int CountOfDying { get; set; } = 1;
    private string defaultString = "Attempt  "; 
    void Update()
    {
        textDeadScore.text = defaultString + CountOfDying.ToString();

    }
}
