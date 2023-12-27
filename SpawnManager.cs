using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] customerPrefabs;
    static public bool customer = false;
    private float startDelay = 2;
    public static SpawnManager Instance;
    public static bool loadCustomer = false;

    void Start()
    {
        if (loadCustomer == true)
        {
            Vector3 spawnpos = new Vector3(-0.47f, -2.01f, -1);
            Instantiate(customerPrefabs[0], spawnpos, customerPrefabs[0].transform.rotation);
        }

        InvokeRepeating("SpawnCustomer", startDelay, Random.Range(1, 45));
    }

    void SpawnCustomer()
    {
       if (customer == false)
        {
            Vector3 spawnpos = new Vector3(-0.47f, -2.01f, -1);
            Instantiate(customerPrefabs[0], spawnpos, customerPrefabs[0].transform.rotation);
            customer = true;
        }
       
    }
}
