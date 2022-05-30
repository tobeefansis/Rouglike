using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Transform healthBar;
    [SerializeField] Health health;

    public void Change()
    {
        gameObject.SetActive(true);
        healthBar.localScale = new Vector3((float)health.Value / health.StartValue, 1, 1);
    }
}
