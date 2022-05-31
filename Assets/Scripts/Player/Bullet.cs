
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int damage;
    [SerializeField] GameObject effect;

    private void FixedUpdate()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var health = collision.GetComponent<Health>();
        if (health)
        {
            health.AddDamage(damage);
        }
        Instantiate(effect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
