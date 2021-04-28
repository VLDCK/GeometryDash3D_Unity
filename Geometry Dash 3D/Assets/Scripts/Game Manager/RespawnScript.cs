using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    public GameManager gameManager;
    public bool scriptIsOn = true;
    
    public void RespawnObject()
    {
        if (scriptIsOn)
        {
            gameManager.GameOver();
        }
    }
    
}
