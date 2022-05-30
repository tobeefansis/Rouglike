using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] int value;
    [SerializeField] int startValue;
    [SerializeField] GameObject effect;
    [SerializeField] UnityEvent OnDamageChange;

    public int Value { get => value; set => this.value = value; }
    public int StartValue { get => startValue; set => startValue = value; }

    public virtual void AddDamage(int damage)
    {
        value -= damage;
        if (value<=0)
        {
            Dead();
        }
        OnDamageChange?.Invoke();
        Instantiate(effect, transform.position, Quaternion.identity);
    }

    public virtual void Dead()
    {
        Destroy(gameObject);
    }
}
