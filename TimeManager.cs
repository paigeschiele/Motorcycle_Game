using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public static TimeManager Instance;
    public static Action OnMinuteChanged;
    public static Action OnHourChanged;
    public static int Minute {  get; set; }
    public static int Hour { get; set; }

    private float minutetoRealTime = 0.5f;
    private float timer;
    void Start()
    {
        Minute = 0;
        Hour = 10;
        timer = minutetoRealTime;
        
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
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            Minute++;
            OnMinuteChanged?.Invoke();

            if(Minute >= 60)
            {
                Hour++;
                Minute = 0;
                OnHourChanged?.Invoke();
            }

            if(Hour >= 12 && Minute >= 59)
            {
                Hour = 0;
            }

            if(Hour == 1)
            {
                SceneManager.LoadScene(3);
            }

            timer = minutetoRealTime;
        }
    }
}
