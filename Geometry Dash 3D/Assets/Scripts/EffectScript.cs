using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectScript : MonoBehaviour
{
    public ParticleSystem cubeEffects;

    public CharacterController cubeContoller = CubeMechanics.cubeContoller; // компонент куба, контроллер

   
    // Update is called once per frame
    void Update()
    {
        EffectPlayCube();
    }
    private void EffectPlayCube()
    {
        if (!cubeContoller.isGrounded)
        {
           cubeEffects.Play();
        }
    }
    
}
