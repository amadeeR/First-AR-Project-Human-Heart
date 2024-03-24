using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartbeatCal : MonoBehaviour
{
    public Text heartbeatText; // Reference to the UI Text component
    private int pulseRate = 0; // Initial pulse rate in beats per minute
    private int maxPulseRate = 100; // Maximum pulse rate

    void Start()
    {
        // Find and assign the UI Text component
        heartbeatText = GetComponentInChildren<Text>();

        // If UI Text component is not found, log an error
        if (heartbeatText == null)
        {
            Debug.LogError("UI Text component not found!");
        }
        else
        {
            // Start the heartbeat simulation
            InvokeRepeating("UpdatePulseRate", 0f, 2f); // Update pulse rate every second
        }
    }

    void UpdatePulseRate()
    {
        // Increase the pulse rate by 1 every second, up to the maximum pulse rate
        if (pulseRate < maxPulseRate)
        {
            pulseRate++;
        }

        // Update the displayed heartbeat text using UI Text
        if (heartbeatText != null)
        {
            heartbeatText.text = "Pulse Rate: " + pulseRate.ToString() + " BPM";
        }
    }
}
