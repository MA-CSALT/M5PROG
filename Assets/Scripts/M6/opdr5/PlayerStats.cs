using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float HP = 100f;
    [SerializeField] private int Points;
    void Start()
    {
        DamageTrap.OnDamaged += TakeDamage;
        HealthPickup.OnHPpickup += GetHp;
        CoinPickup.OnCoinPickup += GetPoints;
    }

    private void TakeDamage()
    {
        HP -= 5f;
    }

    private void GetHp()
    {
        HP += 20f;
    }

    private void GetPoints()
    {
        Points += 10;
    }
    void Update()
    {

    }
}
