using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        SceneManager.LoadScene(1);
        if (SpawnManager.customer == true)
        {
            SpawnManager.loadCustomer = true;
        }
    }
}
