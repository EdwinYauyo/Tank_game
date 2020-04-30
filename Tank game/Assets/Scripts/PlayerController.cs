using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 100f;
    private float initial_impulse = 300f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        rb.AddForce(initial_impulse * movement);
        float vel_x = rb.velocity.x;
        float vel_z = rb.velocity.z;
        rb.velocity = new Vector3(Mathf.Clamp(vel_x, -speed, speed), rb.velocity.y, Mathf.Clamp(vel_z, -speed, speed));
    }
}
