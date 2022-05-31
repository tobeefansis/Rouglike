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
