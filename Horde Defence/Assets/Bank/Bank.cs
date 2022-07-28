using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 150;
    [SerializeField] int currentBalance;
    [SerializeField] TextMeshProUGUI goldText;
    public int CurrentBalance{ get { return currentBalance; } }
    private void Awake()
    {
        currentBalance = startingBalance;
        DisplayBalance();
    }
    public void Deposit(int amount)
    {
        currentBalance += Mathf.Abs(amount);
        DisplayBalance();
    }
    public void Withdraw(int amount)
    {
        currentBalance -= Mathf.Abs(amount);
        DisplayBalance();
    }
    void DisplayBalance()
    {
        goldText.text =$"Gold: {currentBalance}";
    }
}
