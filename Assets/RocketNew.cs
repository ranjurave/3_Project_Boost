using UnityEngine;
using UnityEngine.SceneManagement;

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

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Friendly")
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }

    private void ThrustRocket()
    {
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidBody.AddRelativeForce(Vector3.up * thrustPower);
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(mainEngine);
            }
        }
        else
        {
            audioSource.Stop();
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
