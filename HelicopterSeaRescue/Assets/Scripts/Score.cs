using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class Score : MonoBehaviour
{
    private int inWater;
    private int saved;
    private int drowned;
    private int totalScore;
    private SpawnSailors spawnSailors;
    private GrappleDown grappleDown;
    public TextMeshProUGUI scoremax;
    public TextMeshProUGUI savedSailors;
    public TextMeshProUGUI deadSailors;
    public TextMeshProUGUI sailorsInTheWater;
  
    
    // Start is called before the first frame update
    void Start()
    {
        

            inWater = 0;
            saved = 0;
            drowned = 0;
            totalScore = 0;
            spawnSailors = GameObject.Find("Spawn manager").GetComponent<SpawnSailors>();
            grappleDown = GameObject.Find("floaty").GetComponent<GrappleDown>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
       
            saved = grappleDown.safe;
            drowned = grappleDown.drowned;
            inWater = spawnSailors.inTheWater - saved - drowned;
            totalScore = (saved * 3) - drowned;



            scoremax.text = "Total score " + totalScore;
            savedSailors.text = "Saved = " + saved;
            deadSailors.text = "Drowned = " + drowned;
            sailorsInTheWater.text = "In the water = " + inWater;
        }

    
}
