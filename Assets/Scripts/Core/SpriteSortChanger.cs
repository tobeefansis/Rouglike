using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSortChanger : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    private void FixedUpdate()
    {
        spriteRenderer.sortingOrder = -(int)(transform.position.y*10);
    }
}
