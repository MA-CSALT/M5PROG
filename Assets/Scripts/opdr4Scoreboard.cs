using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class opdr4Scoreboard : MonoBehaviour
{
    private int score = 0;
    [SerializeField]private TMP_Text textField;
    
    void Start()
    {
        textField = GetComponent<TMP_Text>();
        opdr4Pickup.OnPickup += AddPickup;
    }

    private void AddPickup() 
    {
        score += 50;
        textField.text = "score: " + score;
    }
    void Update()
    {
        
    }
}
