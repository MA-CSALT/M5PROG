using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opdr7 : MonoBehaviour
{
    public bool IsPlayerReadyToAttack(Player player)
    {
        if (player == null) return false;
        if (!player.IsAlive) return false;
        if (player.AttackCooldown > 0) return false;
        if (player.Target == null) return false;
        if (!player.Target.IsAlive) return false;
        if (Vector3.Distance(player.transform.position, player.Target.transform.position) <= 5f) return false;
        if (player.Mana < 20) return false;
        if (!player.WeaponEquipped) return false;
        if (player.Health <= 30) return false;
        if (!player.HasBuff("Strength")) return false;
        if (player.IsStunned) return false;
        if (player.IsSlowed) return false;
                           
        return true;
    }
}
