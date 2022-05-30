using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    [SerializeField] GameObject healthEffect;

    public void AddHealth(int value)
    {
        this.Value += value;
        if (Value>StartValue)
        {
            Value = StartValue;
        }
        Instantiate(healthEffect, transform.position, Quaternion.identity);
        OnDamageChange?.Invoke();
    }
}
