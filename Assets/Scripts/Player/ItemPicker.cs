using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPicker : MonoBehaviour
{
    [SerializeField] GameObject button;
    [SerializeField] Shooting shooting;
    [SerializeField] WeaponWorldItem weaponWorldItemPrefab;

    public void SelectItem(InteractivObject obj)
    {
        button.SetActive(obj);
    }

    public void PickUp()
    {
        if (InteractivObjectSelector.InstanceExists)
        {
            if (InteractivObjectSelector.Instance.Selected is WeaponWorldItem weapon)
            {
                var weaponWorldItem = Instantiate(weaponWorldItemPrefab, transform.position, Quaternion.identity);
                weaponWorldItem.Weapon = shooting.Weapon;
                shooting.SetWeapon(weapon.Weapon);
                Destroy(weapon.gameObject);
            }
        }
    }
}
