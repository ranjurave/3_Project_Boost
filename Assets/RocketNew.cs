using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketNew : MonoBehaviour
{

    [SerializeField] float thrustPower = 40f;
    [SerializeField] float rotatePower = 150f;
    Rigidbody rigidBody;
    [SerializeField] AudioClip mainEngine;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rigidBody = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        ThrustRocket();
        RotateRocket();
    }

    private void ThrustRocket()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidBody.AddRelativeForce(Vector3.up * thrustPower);
            audioSource.PlayOneShot(mainEngine);
        }
        else
        {
            //audioSource.Stop();
        }
    }

    private void RotateRocket()
    {
        rigidBody.freezeRotation = true;
        float rotationThisFrame = rotatePower * Time.deltaTime;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-Vector3.forward * rotationThisFrame);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * rotationThisFrame);
        }
    }
}
