using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] Vector3 direction;
    public Joystick variableJoystick;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        var v = variableJoystick.Vertical;
        var h = variableJoystick.Horizontal;

        direction = new Vector3(h, v);
        transform.position += direction * speed * Time.deltaTime;

    }
}
