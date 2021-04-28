using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Класс записів досягнень впродовж ігрового процесу, 
/// та всієї історії для гри
/// </summary>
public class Score : MonoBehaviour
{
    public static int CountOfDying { get; set; } = 1;
    public static int wayPercent = 0;

    public Text [] textDeadScore;
    public Text [] textPercentScore;
    public SliderBehavior slider;
    
    void Update()
    {
        PrintAttempt();
        PrintScore();

        slider.StatusBar();
    }
    public void PrintAttempt() 
    {
        for (int i = 0; i < textDeadScore.Length; i++)
        {
            textDeadScore[i].text = "Attempt  " + CountOfDying.ToString();
        }
    }
    public void PrintScore()
    {
        for (int i = 0; i < textPercentScore.Length; i++)
        {
            textPercentScore[i].text = (100 - wayPercent) + " %";
        }
    }
    
}
