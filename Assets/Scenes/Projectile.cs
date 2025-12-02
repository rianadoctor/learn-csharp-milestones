// CH 8

using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Move forward using Rigidbody.velocity
        rb.velocity = transform.forward * speed;
    }
}
