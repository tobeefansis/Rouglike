using UnityEngine;

[RequireComponent(typeof(EnemyHealth))]
public class Enamy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (EnamyPool.InstanceExists)
        {
            EnamyPool.Instance.Enamies.Add(this);
        }
    }

    private void OnDestroy()
    {
    
    }
    // Update is called once per frame
    void Update()
    {

    }
}
