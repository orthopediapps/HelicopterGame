using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrappleDown : MonoBehaviour
{
    private PlayerController playerController;
    public GameObject rope;
    public GameObject ball;
    private bool touchedSth = false;
    private bool fullyExtended = false;
    public bool catchSailor = false;
    public bool catchPowerUp = false;
    public float zOffset = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        SetBallPosition();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            touchedSth = true;
        }
        if (other.gameObject.CompareTag("sailor"))
        {
           
            catchSailor = true;
        }
        if (other.gameObject.CompareTag("powerUp"))
        {
            
            catchPowerUp = true;
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


}
