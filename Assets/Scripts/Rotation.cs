using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHeart : MonoBehaviour
{
    // Rotation speed
    public float rotationSpeed = 50f;

    void Update()
    {
        // Check for user input (e.g., mouse drag)
        if (Input.GetMouseButton(0)) // Left mouse button
        {
            // Get mouse movement delta
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            // Calculate rotation amount based on mouse movement
            float rotationX = mouseY * rotationSpeed * Time.deltaTime;
            float rotationY = -mouseX * rotationSpeed * Time.deltaTime; // Negative for inverse rotation

            // Apply rotation to the heart object
            transform.Rotate(Vector3.up, rotationY, Space.World);
            transform.Rotate(Vector3.right, rotationX, Space.World);
        }
    }
}