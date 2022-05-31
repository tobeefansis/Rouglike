using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RoomsGenerator : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] List<Room> chancks = new List<Room>();
    [SerializeField] List<Room> chanckPrefubs = new List<Room>();
    [SerializeField] int maxCount;
    [SerializeField] float distance;

    void FixedUpdate()
    {    
        if (Vector2.Distance(target.position, chancks[chancks.Count - 1].end.position) <= distance)
        {
            print("Add Room");
            AddChanck();
        }
    }

    private void AddChanck()
    {
        var chanckPrefub = chanckPrefubs[Random.Range(0, chanckPrefubs.Count)];
        var t = Instantiate(
              chanckPrefub,
             chancks[chancks.Count - 1].end.position - chanckPrefub.start.localPosition,
              new Quaternion());
        chancks.Add(t);
        if (chancks.Count > maxCount)
        {
            Destroy(chancks[0].gameObject);
            chancks.RemoveAt(0);
        }
    }
}
