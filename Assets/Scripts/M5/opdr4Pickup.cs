using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opdr4Pickup : MonoBehaviour
{
    public static event Action OnPickup;

    private void OnTriggerEnter(Collider other)
    {
        OnPickup?.Invoke();
        Destroy(gameObject);
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
