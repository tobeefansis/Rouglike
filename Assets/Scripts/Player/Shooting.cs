
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] Enamy target;
    [SerializeField] SpriteRenderer weaponSpriteRender;
    [SerializeField] Weapon weapon;
    [SerializeField] GameObject aim;
    bool isShooting;
    float timeOfLastShot;

    public Weapon Weapon { get => weapon; set => weapon = value; }

    public Enamy GetTarget()
    {
        return target;
    }

    public void SetTarget(Enamy value)
    {
        if (target != value)
        {
            if (value == null)
            {
                aim.transform.SetParent(null);
                aim.SetActive(false);
            }
            else
            {
                aim.SetActive(true);
                aim.transform.position = value.transform.position;
                aim.transform.SetParent(value.transform);
            }
        }
        target = value;
    }

    internal void SetWeapon(Weapon weapon)
    {
        this.weapon = weapon;
        weaponSpriteRender.sprite = weapon.Image;
        timeOfLastShot = 0;
    }

    void Aiming()
    {
        SetTarget(FindTarget());
        if (target)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, Mathf.Atan2(GetTarget().transform.position.y - transform.position.y, GetTarget().transform.position.x - transform.position.x) * Mathf.Rad2Deg - 90);
        }
        else
        {
            transform.rotation = Quaternion.identity;
        }
    }

    private Enamy FindTarget()
    {
        Enamy min = null;
        if (EnamyPool.InstanceExists)
        {
            foreach (var item in EnamyPool.Instance.Enamies)
            {
                if (min)
                {
                    if (Vector2.Distance(transform.position, min.transform.position) > Vector2.Distance(transform.position, item.transform.position))
                    {
                        min = item;
                    }
                }
                else
                {
                    min = item;
                }
            }
        }

        if (min && Vector2.Distance(transform.position, min.transform.position) <= weapon.Distance)
        {
            return min;
        }
        else
        {
            return null;
        }
    }
    private void FixedUpdate()
    {
        Aiming();
        if (timeOfLastShot >= 0)
        {
            if (isShooting)
            {
                Shot();
                timeOfLastShot = -weapon.Cooldown;
            }
        }
        else
        {
            timeOfLastShot += Time.deltaTime;
        }

    }

    public void Shot()
    {
        weapon.Shot(weaponSpriteRender.transform);
    }

    public void StartShoting()
    {
        isShooting = true;
    }

    public void StopShoting()
    {
        isShooting = false;

    }
}
