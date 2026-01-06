using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : Collectible
{
    public static event Action OnCoinPickup;
    void Start()
    {
        
    }

    public override void OnCollect()
    {
        Debug.Log("Coin collected");
        Destroy(gameObject);
        OnCoinPickup?.Invoke();
    }
    void Update()
    {
        
    }
}
