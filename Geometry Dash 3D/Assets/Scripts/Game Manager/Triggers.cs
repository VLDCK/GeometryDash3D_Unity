using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    public RespawnScript respawn;

    public ObjectChanger objectChanger;
   
    public void OnTriggerEnter(Collider trigger)
    {
        if (trigger.tag == "Respawn") 
        {          
            respawn.RespawnObject();
        }
               
        if (trigger.tag == "ChangeObjectCube") 
        {
            objectChanger.ChangeToAirplane();
        }

        if (trigger.tag == "ChangeObjectAirplane")
        {
            objectChanger.ChangeToCube();
        }

        if (trigger.tag == "Finish")
        {
            GameManager.Finish();
        }
    }
}
