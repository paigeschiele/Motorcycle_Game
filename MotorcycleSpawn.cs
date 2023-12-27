using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorcycleSpawn : MonoBehaviour
{

    public GameObject[] motorcyclePrefabs;
    static public bool motorcycle = false;
    private float startDelay = 2;
    static public bool Motorcycleload = false;

    void Start()
    {
        InvokeRepeating("SpawnMotorcycle", startDelay, Random.Range(1, 25));

        if (Motorcycleload == true)
        {
            Vector3 spawnpos = new Vector3(-3.98f, -7.48f, -3);
            Instantiate(motorcyclePrefabs[0], spawnpos, motorcyclePrefabs[0].transform.rotation);
        }
    }

    void SpawnMotorcycle()
    {
        if (motorcycle == false)
        {
            Vector3 spawnpos = new Vector3(-3.98f, -7.48f, -3);
            Instantiate(motorcyclePrefabs[0], spawnpos, motorcyclePrefabs[0].transform.rotation);
            motorcycle = true;
        }

    }
}
