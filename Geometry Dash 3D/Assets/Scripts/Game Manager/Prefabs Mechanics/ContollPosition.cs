using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContollPosition : MonoBehaviour
{
    public Transform gameObjectPoint;
    public Transform spawnPosition;
    public void ConfirmPositionPlane()
    {
        gameObjectPoint.transform.position = spawnPosition.transform.position;
        Physics.SyncTransforms();
    }

    public void ConfirmPositionCube() 
    {
        gameObjectPoint.transform.position = spawnPosition.transform.position;
        Physics.SyncTransforms();
    }



}
