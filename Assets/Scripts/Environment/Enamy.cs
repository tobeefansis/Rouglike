
using UnityEngine;

[RequireComponent(typeof(EnemyHealth))]
public class Enamy : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float runDistance;
    [SerializeField] float attackDistance;
    [SerializeField] Transform player;
    [SerializeField] Weapon weapon;
    [SerializeField] SpriteRenderer weaponImage;
    float timeOfLastShot;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer image;
    // Start is called before the first frame update
    void Start()
    {
        if (EnamyPool.InstanceExists)
        {
            EnamyPool.Instance.Enamies.Add(this);
            player = EnamyPool.Instance.Player.transform;
        }
        weaponImage.sprite = weapon.Image;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        weaponImage.gameObject.SetActive(false);
        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= runDistance)
        {
            weaponImage.transform.parent.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, Mathf.Atan2(player.position.y - transform.position.y, player.position.x - transform.position.x) * Mathf.Rad2Deg - 90);
            animator.SetBool("Run", true);
            image.flipX = transform.position.x - player.position.x < 0;
            weaponImage.gameObject.SetActive(true);
            if (distance <= attackDistance)
            {
                if (timeOfLastShot >= 0)
                {
                    Attack();
                    timeOfLastShot = -weapon.Cooldown;
                }
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }

        }
        else
        {
            weaponImage.gameObject.SetActive(false);
            animator.SetBool("Run", false);
        }
        timeOfLastShot += Time.deltaTime;
    }

    private void Attack()
    {

        weapon.Shot(weaponImage.transform);
    }
}
