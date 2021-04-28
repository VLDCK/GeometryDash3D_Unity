using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneMechanics : MonoBehaviour
{

    public const float SPEED_POWER = 25f; // швідкість об'єкта
    
    public float jumpPower = 11; // сила стрибка об'єкта

    float gravityForce = -1f; // гравітація об'єкта
    private Vector3 directionMove = new Vector3(0, 0, SPEED_POWER); // напрямок руху
    
    public float rotationSpeed;  // швидкість обератання

    //public float adjustFactorOfRotation = 100;// для регулювання коефіцієнту обертання до прямого кута

    public static CharacterController airplaneContoller; // компонент літака, контроллер
    // Start is called before the first frame update
    void Start()
    {
        airplaneContoller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CubeMove();

        Gravity();

        RotateByDirect();

    }

    void CubeMove()
    {
        directionMove.y = gravityForce; // вплив гравітації на об'єкт по осі ординат
                                       // рух зі швидкістю визначеною в полі Vector3 - швидкість 
        airplaneContoller.Move(directionMove * Time.deltaTime);
    }

    void Gravity()
    {
        InSky();
        TakeOffGround();
    }
    void InSky()
    {
        if (!airplaneContoller.isGrounded)
        {
            gravityForce -= 20f * Time.deltaTime;
        }
        else gravityForce = -1f;
    }
    void TakeOffGround() 
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
        {
            gravityForce = jumpPower;
        }
    }

    private void RotateByDirect()
    {
        
        Vector3 rotationDirect = Vector3.RotateTowards(transform.forward,
                                                       directionMove, rotationSpeed, 0.0f);
        transform.rotation = Quaternion.LookRotation(rotationDirect);
       
                
    }
}
