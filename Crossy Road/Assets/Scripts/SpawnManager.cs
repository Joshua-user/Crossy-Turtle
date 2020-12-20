using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Prefabs;

    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandom", startDelay, spawnInterval);
    }
    void SpawnRandom()
    {
       
        {
            int Index = Random.Range(0, Prefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(Prefabs[Index], spawnPos, Prefabs[Index].transform.rotation);
        
        }

    }
}
