using UnityEngine;

public class PlayerHealth : Health
{
    [SerializeField] GameObject healthEffect;

    public void AddHealth(int value)
    {
        this.Value += value;
        if (Value > StartValue)
        {
            Value = StartValue;
        }
        Instantiate(healthEffect, transform.position, Quaternion.identity, transform);
        OnDamageChange?.Invoke();
    }
    public override void Dead()
    {
        Debug.Log("Dead");
    }
}
