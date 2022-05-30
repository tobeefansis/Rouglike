using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Weapon : ScriptableObject
{
    [SerializeField] GameObject bullet;
    [SerializeField] Sprite image;
    [SerializeField] GameObject effect;
    [SerializeField] float cooldown;
    [SerializeField] float distance;

    public GameObject Bullet { get => bullet; set => bullet = value; }
    public Sprite Image { get => image; set => image = value; }
    public float Cooldown { get => cooldown; set => cooldown = value; }
    public GameObject Effect { get => effect; set => effect = value; }
    public float Distance { get => distance; set => distance = value; }

    public void Shot(Transform gun)
    {
        Instantiate(Bullet, gun.position, gun.rotation);
    }
}
