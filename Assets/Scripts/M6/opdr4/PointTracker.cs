using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PointTracker : MonoBehaviour
{
    private int points = 0;
    [SerializeField] private TMP_Text textField;

    void Start()
    {
        Player.playerPickup += PointsAdded;
    }

    public void PointsAdded()
    {
        points += 10;
        textField.text = "points: " + points;
        Debug.Log("tracker");
    }
    void Update()
    {
        
    }
}
