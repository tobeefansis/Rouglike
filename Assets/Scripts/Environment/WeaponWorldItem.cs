
using DG.Tweening;

using UnityEngine;

public class WeaponWorldItem : WorldItem
{
    [SerializeField] Weapon weapon;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Vector3 offset;
    [SerializeField] float jumpPower;
    [SerializeField] float duration;

    private void Start()
    {
        spriteRenderer.sprite = weapon.Image;
        transform.DOJump(transform.position + offset, jumpPower, 1, duration);
    }
    public Weapon Weapon { get => weapon; set => weapon = value; }
}
