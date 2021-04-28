using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChanger: MonoBehaviour
{
    public GameObject cube;
    public GameObject airplane;
    
    public ContollPosition contollPositionPlane;
    public ContollPosition contollPositionCube;

    public void ChangeToAirplane()
    {
        cube.transform.position = new Vector3(0,0,-635);
        cube.SetActive(false);
        contollPositionPlane.ConfirmPositionPlane();
        airplane.SetActive(true);
    }
    public void ChangeToCube()
    {
        cube.SetActive(true);
        contollPositionCube.ConfirmPositionCube();
        airplane.SetActive(false);
        
    }
}
