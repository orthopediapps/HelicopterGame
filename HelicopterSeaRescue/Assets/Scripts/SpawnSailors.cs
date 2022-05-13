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
    

    // Update is called once per frame
    void Update()
    {
        SetRandoms();

        if (!sailorSpawned)
        {
            StartCoroutine(SpawnTimer());
        }
    }
    IEnumerator SpawnTimer()
    {
        SpawnNewSailor();
        yield return new WaitForSeconds(spawnInterval);
        sailorSpawned = false;
    }
    public void SpawnNewSailor()
    {
        coordx = Random.Range(0, 301);
        coordz = Random.Range(0, 301);
        Instantiate(peoplePrefabs[index], new Vector3(coordx, 0, coordz), transform.rotation);
        sailorSpawned = true;
    }

    private void SetRandoms()
    {
        spawnInterval = Random.Range(10, 60);
        index = Random.Range(0, 3);
    }
}
