using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Customer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        Destroy(gameObject);
        GameManager.money += 10;
        SpawnManager.customer = false;
        MoneyUI.OnMoneyChange?.Invoke();

    }
}
