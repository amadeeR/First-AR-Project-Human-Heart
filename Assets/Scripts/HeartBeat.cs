using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heartbeat : MonoBehaviour
{
    // Variables to control heartbeat animation
    public float maxScale = 1.2f; // Maximum scale of the heartbeat
    public float minScale = 0.8f; // Minimum scale of the heartbeat
    public float beatSpeed = 1.0f; // Speed of the heartbeat animation

    // Reference to the AudioSource component
    private AudioSource audioSource;

    // Reference to the heartbeat audio clip
    public AudioClip heartbeatAudio;

    private Vector3 baseScale; // Initial scale of the heart object

    void Start()
    {
        // Record the initial scale of the heart object
        baseScale = transform.localScale;

        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
        // Assign the heartbeat audio clip
        audioSource.clip = heartbeatAudio;
        // Play the heartbeat audio clip
        audioSource.Play();
    }

    void Update()
    {
        // Calculate the scale factor based on time
        float scaleFactor = Mathf.PingPong(Time.time * beatSpeed, 1.0f);

        // Interpolate between the minimum and maximum scales
        float scale = Mathf.Lerp(minScale, maxScale, scaleFactor);

        // Apply the scale to the heart object
        transform.localScale = baseScale * scale;
    }
}
