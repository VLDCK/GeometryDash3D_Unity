using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ссс : MonoBehaviour
{
    CubeMechanics cubeMechanics;
    public GameObject cubeBoxCollider;
    public float rotationPoint;
    // Start is called before the first frame update
    void Start()
    {
        cubeBoxCollider = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!CubeMechanics.cubeContoller.isGrounded)
        {

            Quaternion rotX = Quaternion.AngleAxis(rotationPoint, Vector3.right);
            transform.rotation *= rotX;
            //if(transform.Rotate(90,0,0))
        }  
    }
}
