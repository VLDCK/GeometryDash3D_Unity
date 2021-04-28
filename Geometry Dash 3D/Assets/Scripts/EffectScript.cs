using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectScript : MonoBehaviour
{
    public ParticleSystem cubeEffects;

    public CharacterController cubeContoller = CubeMechanics.cubeContoller; 
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
