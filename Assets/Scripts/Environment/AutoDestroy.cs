using System.Collections;

using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    [SerializeField] float timeToDestroy;
    void Start()
    {
        StartCoroutine(Destroyer());
    }
    IEnumerator Destroyer()
    {
        yield return new WaitForSeconds(timeToDestroy);
        Destroy(gameObject);
    }
}
