using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketNew : MonoBehaviour
{

    [SerializeField] float thrustPower = 2f;
    Rigidbody rigidBody;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        ThrustRocket();
    }

    private void ThrustRocket()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidBody.AddRelativeForce(Vector3.up * thrustPower);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward);
        }
    }
}
