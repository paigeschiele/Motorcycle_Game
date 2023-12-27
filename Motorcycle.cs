using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motorcycle : MonoBehaviour
{
    static public int fixCount = 3;
    static public int tool;
    public GameObject[] toolTextBoxPrefabs;
    public GameObject textbox;

    public void Start()
    {
        toolNeeded();
        DisplayTool();
    }

    public void Update()
    {

        if (fixCount == 0)
        {
            Destroy(gameObject);
            MotorcycleSpawn.motorcycle = false;
            GameManager.money += 100;
            MoneyUI.OnMoneyChange?.Invoke();
            fixCount = Random.Range(3, 7);

        }
    }

    public int toolNeeded()
    {
        if(MotorcycleSpawn.Motorcycleload == false)
        {
            tool = Random.Range(0, 3);
        }
        else
        {
            tool = Door.motorcycleTool;
        }

        return tool;

    }

    public void OnMouseDown()
    {

        if (GameManager.toolID == tool)
        {
            fixCount -= 1;
            tool = Random.Range(0, 3);
            Destroy(textbox);
        }
    }
    public void OnMouseUp()
    {
        if (textbox == null)
        {
            DisplayTool();
        }
    }

    public void DisplayTool()
    {
        Vector3 spawnpos = new Vector3(-3.98f, -5.48f, -3);
        if (tool == 0)
        {
            textbox = Instantiate(toolTextBoxPrefabs[0], spawnpos, toolTextBoxPrefabs[0].transform.rotation);
        }
        else if (tool == 1) 
        {
            textbox = Instantiate(toolTextBoxPrefabs[1], spawnpos, toolTextBoxPrefabs[1].transform.rotation);
        }
        else if(tool == 2)
        {
            textbox = Instantiate(toolTextBoxPrefabs[2], spawnpos, toolTextBoxPrefabs[2].transform.rotation);
        }
    }
}
