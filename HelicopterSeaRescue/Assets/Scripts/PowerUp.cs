using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    private bool hasPowerUp = false;
    private PlayerController playerController;
    private int newSpeed;
    public AudioSource powerUpAudio;
    public AudioClip speedPowerUp;
    // Start is called before the first frame update
    void Start()
    {
     playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.CompareTag("Player")|| other.CompareTag("float")) && !hasPowerUp)
        {
            hasPowerUp = true;
            Destroy(gameObject);
            StartCoroutine(AddPowerUp());
            powerUpAudio.PlayOneShot(speedPowerUp);
        }
    }

    IEnumerator AddPowerUp()
    {
        
         newSpeed = Random.Range(100, 200);
        playerController.forwardSpeed = newSpeed;
        yield return new WaitForSeconds(60.0F);
        hasPowerUp = false;
        newSpeed = 40;
        

    }
}
