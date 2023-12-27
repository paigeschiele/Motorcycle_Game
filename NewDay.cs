using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewDay : MonoBehaviour
{
    public void newDay()
    {
        SceneManager.LoadScene(1);
        GameManager.day += 1;
        TimeManager.Hour = 10;
        TimeManager.Minute = 0;
        GameManager.SaveData();
    }
}
