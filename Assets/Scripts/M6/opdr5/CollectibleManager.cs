using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    
    void Start()
    {
        
        
        DamageTrap.OnDamaged += Collected;
        HealthPickup.OnHPpickup += Collected;
        CoinPickup.OnCoinPickup += Collected;
    }

    private void Collected()
    {

    }
    void Update()
    {
        
    }
}
