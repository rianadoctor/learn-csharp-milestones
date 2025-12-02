//CH 7
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;
    public float rotateSpeed = 120f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Rotation
        float horizontal = Input.GetAxis("Horizontal"); // A/D
        transform.Rotate(Vector3.up * horizontal * rotateSpeed * Time.deltaTime);

        // Forward/backward movement
        float vertical = Input.GetAxis("Vertical"); // W/S
        Vector3 moveDir = transform.forward * vertical;

        // Move using Translate
        transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.World);
    }

    void FixedUpdate()
    {
        // physics-based movement

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;
        rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
    }

    // Collision dectection
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name);
    }

    // Trigger detection
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered trigger: " + other.gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited trigger: " + other.gameObject.name);
    }

    
    void OnCollisionStay(Collision collision)
    {
        // If you collide with something tagged as enemy then destroy
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
}
