using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int value;
    [SerializeField] GameObject effect;

    public void AddDamage(int damage)
    {
        value -= damage;
        Instantiate(effect, transform.position, Quaternion.identity);
    }
}
