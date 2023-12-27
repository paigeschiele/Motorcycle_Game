using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyUI : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    public static Action OnMoneyChange;

    public void Start()
    {
        moneyText.text = $"{GameManager.money}";
    }
    public void OnEnable()
    {
        OnMoneyChange += UpdateMoney;

    }


    private void OnDisable()
    {
        OnMoneyChange -= UpdateMoney;
    }

    private void UpdateMoney()
    {
        moneyText.text = $"{GameManager.money}";
    }
}
