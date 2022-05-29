using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnamyPool : Singleton<EnamyPool>
{

    [SerializeField] List<Enamy> enamies = new List<Enamy>();

    public List<Enamy> Enamies { get => enamies; set => enamies = value; }
}
