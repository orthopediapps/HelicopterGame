using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float verticalSpeed = 0.1f;
    [SerializeField]
    private float forwardSpeed = 40;
    [SerializeField]
    private float turnSpeed = 70;
    private bool upThrust;
    private bool downThrust;
    private float forwardThrust;
    private float turnThrust;
    private bool releaseGrapple = false;
    public bool grappleIsDown = false;
    [SerializeField]
    private int limits = 850;
    public GameObject rope;
    private DrownTimer drownTimer;
    public AudioClip wincher;
    public AudioSource ropeMotor;

     
    
    void Update()
    {
        KeyControls();
        HeliMove();
        FlyRange();
        
        
    }


    // ABSTRACTION. Moved all keys and axis inputs to KeyControls() method.
    void KeyControls()
    {
        upThrust = Input.GetKey(KeyCode.F);
        downThrust = Input.GetKey(KeyCode.V);
        forwardThrust = Input.GetAxis("Vertical");
        turnThrust = Input.GetAxis("Horizontal");
        releaseGrapple = Input.GetKeyDown(KeyCode.Space);

    }
    void HeliMove()
    {
        if (upThrust)
        {
            transform.Translate(Vector3.up * verticalSpeed);
        }
        if (downThrust)
        {
            transform.Translate(Vector3.down * verticalSpeed);
        }
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed * forwardThrust);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * turnThrust);

        if (releaseGrapple)
        {
            ropeMotor.PlayOneShot(wincher, 0.5F);
            grappleIsDown = true;
            rope.SetActive(true);
 
        }

    }
    void FlyRange()
    {
        if (transform.position.x > limits)
        {
            transform.position = new Vector3(limits, transform.position.y, transform.position.z);
        }
        if (transform.position.z > limits)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, limits);
        }
        if (transform.position.x < -limits)
        {
            transform.position = new Vector3(-limits, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -limits)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -limits);
        }
    }
    
    
    
}
