
using UnityEngine;

public class InteractivObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerHealth>();
        if (player)
        {
            if (InteractivObjectSelector.InstanceExists)
            {
                InteractivObjectSelector.Instance.Select(this);
            }
            OnSelect(player);
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
    public virtual void OnSelect(PlayerHealth player)
    {
        print("OnSelect");

    }
    public virtual void OnDiselect()
    {
        //   print("OnDiselect");

    }
    public virtual void OnUse()
    {

    }
}
