using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthWorldItem : WorldItem
{
    [SerializeField] int value;

    public override void OnSelect(PlayerHealth player)
    {
        player.AddHealth(value);
        Destroy(gameObject);
    }
}
