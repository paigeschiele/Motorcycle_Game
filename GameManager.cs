using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    static public int money;
    static public int day = 1;
    public static TextMeshProUGUI moneyText;
    static public int toolID;

    private void Update()
    {
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadData();
    }

    [Serializable]
    public class PlayerData
    {
        public int money;
        public int day;
    }

    static public void SaveData()
    {
        PlayerData data = new PlayerData();
        data.day = day;
        data.money = money;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            PlayerData data = JsonUtility.FromJson<PlayerData>(json);

            day = data.day;
            money = data.money;
        }
    }
}
