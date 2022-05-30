using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class InteractivObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerHealth>())
        {
            if (InteractivObjectSelector.InstanceExists)
            {
                InteractivObjectSelector.Instance.Select(this);
            }
            OnSelect();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerHealth>())
        {
            if (InteractivObjectSelector.InstanceExists)
            {
                InteractivObjectSelector.Instance.Diselect();
            }
        }
    }
    public virtual void OnSelect()
    {
        print("OnSelect");

    }
    public virtual void OnDiselect()
    {
        print("OnDiselect");

    }
    public virtual void OnUse()
    {

    }
}
