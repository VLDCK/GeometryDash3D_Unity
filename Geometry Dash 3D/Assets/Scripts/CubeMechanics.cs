using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMechanics : MonoBehaviour
{
    public const float speedPower = 14f; // швідкість об'єкта
    public float jumpPower = 11; // сила стрибка об'єкта

    float gravityForce = -1f; // гравітація об'єкта
    private Vector3 directionMove = new Vector3(0,0, speedPower); // напрямок руху
    public float rotationSpeed;  // швидкість обератання

    public float adjustFactorOfRotation = 100;// для регулювання коефіцієнту обертання до прямого кута

    public static CharacterController cubeContoller; // компонент куба, контроллер
    

    
    // Start is called before the first frame update
    public void Start()
    {
        // посилання на компоненти об'єкта
        cubeContoller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        CubeMove(); // виклик методу руху об'єкта 

        Graviry(); // виклик методу обчислення гравітаціїї для об'єкта

        Rotate(); // виклик методу обертання для об'єкта

        RotateIfNotRightAngle();

    }

    // метод переміщення об'єкта
    private void CubeMove()
    {
        directionMove.y = gravityForce; // вплив гравітації на об'єкт по осі ординат
        // рух зі швидкістю визначеною в полі Vector3 - швидкість 
        cubeContoller.Move(directionMove * Time.deltaTime);   
    }

    //метод гравітації об'єкта
    private void Graviry()
    {
        if (!cubeContoller.isGrounded){
            gravityForce -= 30f * Time.deltaTime;
        }
        else gravityForce = -1f;

        if (cubeContoller.isGrounded && Input.GetKey(KeyCode.Space))
        {
            gravityForce = jumpPower;
        }
    }

    //метод обертання об'єкта
    private void Rotate()
    {
        if (!cubeContoller.isGrounded)
        {
            Quaternion rotX = Quaternion.AngleAxis(rotationSpeed, Vector3.right);
            transform.rotation *= rotX;
        }
    }

    //метод обертання об'єкта, довертає об'єкт якщо він приземлився не прямим кутом
    private void RotateIfNotRightAngle()
    {
        if (cubeContoller.isGrounded)
        {
            if (transform.localEulerAngles.x > 0)   {
                Quaternion target90 = Quaternion.Euler(90, 0, 0);
                transform.rotation = Quaternion.Slerp(transform.rotation, target90,
                    adjustFactorOfRotation);
            }

            if (transform.localEulerAngles.x < 0)
            {
                Quaternion target180 = Quaternion.Euler(-180, 0, 0);
                transform.rotation = Quaternion.Slerp(transform.rotation, target180,
                    adjustFactorOfRotation);
            }
        }

    }

   
}

     
    

