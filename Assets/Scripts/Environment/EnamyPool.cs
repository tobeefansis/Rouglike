using System.Collections.Generic;

using UnityEngine;

public class EnamyPool : Singleton<EnamyPool>
{

    [SerializeField] List<Enamy> enamies = new List<Enamy>();
    [SerializeField] PlayerHealth player;

    public List<Enamy> Enamies { get => enamies; set => enamies = value; }
    public PlayerHealth Player { get => player; set => player = value; }
}
