
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] Vector3 direction;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer spriteRenderer;

    public Joystick variableJoystick;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        var v = variableJoystick.Vertical;
        var h = variableJoystick.Horizontal;
        spriteRenderer.flipX = h < 0;
        if (h != 0 && v != 0)
        {
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }
        direction = new Vector3(h, v);
        transform.position += direction * speed * Time.deltaTime;

    }
}
