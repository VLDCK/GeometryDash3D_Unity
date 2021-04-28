using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpMenuController : MonoBehaviour
{
    public GameObject firstScene;
    public GameObject secondScene;

    public void ChangeGuideNext() 
    {
        firstScene.SetActive(false);
        secondScene.SetActive(true);
    }
    public void ChangeGuideBack()
    {
        firstScene.SetActive(true);
        secondScene.SetActive(false);
    }
}
