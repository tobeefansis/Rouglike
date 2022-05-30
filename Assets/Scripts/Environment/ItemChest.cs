using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ItemChest : WorldItem
{
    [SerializeField] GameObject emptyChestPrefub;
    [SerializeField] WeaponWorldItem weaponWorldItemPrefab;

    public override void OnSelect(PlayerHealth player)
    {
        var weaponWorldItem = Instantiate(weaponWorldItemPrefab, transform.position, Quaternion.identity);
        if (RoomWeaponsList.InstanceExists)
        {
            weaponWorldItem.Weapon = RoomWeaponsList.Instance.Weapons[Random.Range(0, RoomWeaponsList.Instance.Weapons.Count)];
        }
        Instantiate(emptyChestPrefub, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
