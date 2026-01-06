using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Collectible
{
    public static event Action OnHPpickup;

    void Start()
    {
        
    }

    public override void OnCollect()
    {
        Debug.Log("Health restored!");
        Destroy(gameObject);
        OnHPpickup?.Invoke();
    }
    void Update()
    {
        
    }
}
