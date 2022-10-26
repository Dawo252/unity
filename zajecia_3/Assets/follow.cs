using UnityEngine;

public class follow : MonoBehaviour
{
    // Smooth towards the height of the target

    public Transform target;
    float smoothTime = 0.3f;
    float xVelocity = 0.2f;

    void Update()
    {
        float newPositionx = Mathf.SmoothDamp(transform.position.x, target.position.x, ref xVelocity, smoothTime);
        float newPositionz = Mathf.SmoothDamp(transform.position.z, target.position.z, ref xVelocity, smoothTime);
        transform.position = new Vector3(newPositionx, transform.position.y, newPositionz);
    }
}
