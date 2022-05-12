using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSailors : MonoBehaviour
{
    public GameObject[] peoplePrefabs;
    public int index;
    public int spawnInterval;
    bool sailorSpawned = false;
    

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
        Instantiate(peoplePrefabs[index], transform.position + new Vector3(index,0, spawnInterval), transform.rotation);
        sailorSpawned = true;
    }

    private void SetRandoms()
    {
        spawnInterval = Random.Range(5, 10);
        index = Random.Range(0, 3);
    }
}
