using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private int limits = 100;
    private Vector3 offset = new Vector3(0,30, -80);
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player.transform.position.z > limits)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 30, limits - 80);
        }

        else
        {
            transform.position = player.transform.position + offset;
        }

    }
}
