using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    public GameManager gameManager;
    [SerializeField] private Transform gameObjectPoint;
    [SerializeField] private Transform spawnPosition;
    
    public void OnTriggerEnter(Collider dieTrigger)
    {
        if(dieTrigger.tag=="Respawn")
        {
            gameManager.GameOver();
            gameObjectPoint.transform.position = spawnPosition.transform.position;
            Physics.SyncTransforms();
        }
    }
    public void OnTriggerExit(Collider finish)
    {
        if (finish.tag == "Finish")
        {
            Debug.Log("its finish");
            //gameManager.GameOver();
        }
    }
}
