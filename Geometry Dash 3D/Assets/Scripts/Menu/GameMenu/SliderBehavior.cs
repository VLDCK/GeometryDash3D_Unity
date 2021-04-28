using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class SliderBehavior : MonoBehaviour
{
    public GameObject cube;
    public GameObject plane;
    public Transform finish;
    public Slider levelStatus;

    private float _distanceBetweenPoints;
    private float _distanceForObject ;
    private void Start()
    {
        _distanceForObject = Vector3.Distance(cube.transform.position, finish.position);
    }
    public void StatusBar()
    {
        if (cube.activeInHierarchy)
        {
            CubeStatus();
        }
        else if (plane.activeInHierarchy)
        {
            PlaneStatus();
        }
    }
    void CubeStatus()
    {
       _distanceBetweenPoints = Vector3.Distance(cube.transform.position, finish.position);
       levelStatus.value = _distanceBetweenPoints / _distanceForObject;
       Score.wayPercent = ((int)((_distanceBetweenPoints * 100) / _distanceForObject));
    }
    void PlaneStatus()
    {
        _distanceBetweenPoints = Vector3.Distance(plane.transform.position, finish.position);
        levelStatus.value = _distanceBetweenPoints / _distanceForObject;
        Score.wayPercent = ((int)((_distanceBetweenPoints * 100) / _distanceForObject));
    }
}
