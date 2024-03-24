using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The transform of the heart model
    public float distance = 5.0f; // Initial distance between camera and heart
    public float height = 1.0f; // Initial height of the camera above the heart
    public float smoothSpeed = 0.125f; // Speed of camera movement

    Vector3 offset;

    void Start()
    {
        offset = new Vector3(0, height, -distance);
    }

    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the desired position of the camera
            Vector3 desiredPosition = target.position + offset;

            // Smoothly move the camera towards the desired position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            // Make the camera look at the target heart model
            transform.LookAt(target);
        }
    }
}
