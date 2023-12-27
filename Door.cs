using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    static public int motorcycleTool;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMouseDown()
    {
        SceneManager.LoadScene(2);
        if (MotorcycleSpawn.motorcycle == true)
        {
            MotorcycleSpawn.Motorcycleload = true;
            motorcycleTool = Motorcycle.tool;
        }

    }
}
