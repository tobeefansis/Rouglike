using System.Collections.Generic;

using UnityEngine;

public class RoomWeaponsList : Singleton<RoomWeaponsList>
{
    [SerializeField] List<Weapon> weapons = new List<Weapon>();

    public List<Weapon> Weapons { get => weapons; set => weapons = value; }
}
