using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] int value;
    [SerializeField] int startValue;
    [SerializeField] GameObject damageEffect;
    [SerializeField] UnityEvent onDamageChange;

    public int Value { get => value; set => this.value = value; }
    public int StartValue { get => startValue; set => startValue = value; }
    public UnityEvent OnDamageChange { get => onDamageChange; set => onDamageChange = value; }

    public virtual void AddDamage(int damage)
    {
        value -= damage;
        if (value <= 0)
        {
            Dead();
        }
        OnDamageChange?.Invoke();
        Instantiate(damageEffect, transform.position, Quaternion.identity);
    }

    public virtual void Dead()
    {
        Destroy(gameObject);
    }
}
