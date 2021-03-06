using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSailors : MonoBehaviour
{
    public GameObject[] peoplePrefabs;
    public int index;
    public int spawnInterval;
    bool sailorSpawned = false;
    int coordx;
    int coordz;
    public int inTheWater =0;
   
    

    // Update is called once per frame
    void Update()
    {
        SetRandoms();

        if (!sailorSpawned)
        {
            StartCoroutine(SpawnTimer());
        }
    }
   public IEnumerator SpawnTimer()
    {
        SpawnNewSailor();
        yield return new WaitForSeconds(spawnInterval);
        sailorSpawned = false;
    }
    public void SpawnNewSailor()
    {
        coordx = Random.Range(0, 150);
        coordz = Random.Range(0, 150);
        Instantiate(peoplePrefabs[index], new Vector3(coordx, 0, coordz), transform.rotation);
        sailorSpawned = true;
        
        if (index != 3)
        {
          inTheWater++; 
        }
        
    }

    private void SetRandoms()
    {
        spawnInterval = Random.Range(10, 60);
        index = Random.Range(0, 4);
    }
}
