using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public  Slider musicLevelStatus;
    void Update()
    {
        AudioListener.volume = musicLevelStatus.value;
    }
}
