using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrappleDown : MonoBehaviour
{
    private PlayerController playerController;
    public GameObject rope;
    public GameObject ball;
    private bool touchedSth = false;
    public bool fullyExtended = false;
    public bool catchSailor = false;
    public bool catchPowerUp = false;
    public float zOffset = 0f;
    public FixedJoint FJ;
    private GameObject rescuedSailor;
    public AudioSource ballAudio;
    public AudioClip saved;
    public AudioClip deployed;
    public AudioClip dead;
    public int safe;
    public int drowned;
    
    

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
       


    }

    // Update is called once per frame
    void Update()
    {
        SetBallPosition();
        if (catchSailor && rescuedSailor !=null)
        {
            rescuedSailor.transform.position = ball.transform.position + new Vector3(0, 0, -1);
        }
        
      
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            touchedSth = true;
        }
        if (other.gameObject.CompareTag("sailor"))
        {
           if (rescuedSailor && !catchSailor)
            catchSailor = true;
            rescuedSailor = other.gameObject;
            ballAudio.PlayOneShot(saved);
           
           
            
        }

        if (other.gameObject.CompareTag("helipad") && catchSailor)
        {    ballAudio.PlayOneShot(deployed);
            if (rescuedSailor != null)
            {
                Destroy(rescuedSailor);
                catchSailor = false;
                safe++;
            }
           
        }
        

    }

    private void SetBallPosition()
    {
        ball.transform.position = new Vector3(playerController.transform.position.x, playerController.transform.position.y - zOffset, playerController.transform.position.z);

        if (playerController.grappleIsDown && !fullyExtended)

        {
            zOffset = zOffset + 0.1f;
            

            if ((ball.transform.position.y < (playerController.transform.position.y - 10)) || touchedSth)
            {
                
                fullyExtended = true;
                playerController.grappleIsDown = false;
                
                
            }
        }

        if (fullyExtended && playerController.grappleIsDown)
        {
            
            zOffset = zOffset - 0.1f;
            
            if (ball.transform.position.y >= playerController.transform.position.y)
            {
                zOffset = 0;
                fullyExtended = false;
                playerController.grappleIsDown = false;
                touchedSth = false;
                
            }
        }
    }

    public void sailorDied()
    {
        ballAudio.PlayOneShot(dead, 0.5F);
        drowned++;
        
    }


}
