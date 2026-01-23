using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void OnPickup();
    public static event OnPickup playerPickup;
    private void OnTriggerEnter(Collider other)
    {
        playerPickup?.Invoke();
        Destroy(other.gameObject);
        Debug.Log("test");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
