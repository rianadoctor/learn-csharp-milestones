// CH 7

using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; 
    public Vector3 offset = new Vector3(0, 6, -10);
    public float smoothSpeed = 10f;

    void LateUpdate()
    {
        if (target == null) return;

        // Follow
        Vector3 desiredPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPos, smoothSpeed * Time.deltaTime);

        // Look at the player
        transform.LookAt(target);
    }
}
