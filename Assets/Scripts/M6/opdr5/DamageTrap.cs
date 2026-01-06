using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTrap : Collectible
{
    public static event Action OnDamaged;
    void Start()
    {
        
    }

    public override void OnCollect()
    {
        Debug.Log("BOOM!!!!");
        Destroy(gameObject);
        OnDamaged?.Invoke();
    }
    void Update()
    {
        
    }
}
