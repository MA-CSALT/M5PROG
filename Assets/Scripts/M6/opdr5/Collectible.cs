using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectible : MonoBehaviour
{
    public abstract void OnCollect();

    public void OnTriggerEnter(Collider other)
    {
        OnCollect();
    }
}
