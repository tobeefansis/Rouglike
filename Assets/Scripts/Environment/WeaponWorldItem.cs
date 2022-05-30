using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponWorldItem : WorldItem
{
    [SerializeField] Weapon weapon;
    [SerializeField] SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer.sprite = weapon.Image;
    }
    public Weapon Weapon { get => weapon; set => weapon = value; }
}
