using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rigidbody;
    private BoxCollider boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
            
    }
    public void JumpRot() 
    {
        if (Physics.Raycast(transform.position, Vector3.down, boxCollider.size.y / 2 + 0.4f))
        {
            Quaternion rotation = transform.rotation;
            rotation.x = Mathf.Round(rotation.x / 90) * 90;
            transform.rotation = rotation;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody.velocity = Vector3.zero;
                rigidbody.AddForce(Vector3.up * 55000);
            }
            else
            {
                transform.Rotate(Vector3.right * 5f);
            }
        }
    }
}
