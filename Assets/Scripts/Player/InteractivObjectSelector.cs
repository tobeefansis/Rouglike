
using UnityEngine;
using UnityEngine.Events;

public class InteractivObjectSelector : Singleton<InteractivObjectSelector>
{
    [SerializeField] InteractivObject selected;
    public UnityEvent<InteractivObject> ChangeSelection;

    public InteractivObject Selected { get => selected; set => selected = value; }

    public void Select(InteractivObject interactivObject)
    {
        Diselect();
        selected = interactivObject;
        ChangeSelection?.Invoke(selected);
    }
    public void Diselect()
    {

        if (selected)
        {
            selected.OnDiselect();
        }
        selected = null;
        ChangeSelection?.Invoke(selected);
    }
}
