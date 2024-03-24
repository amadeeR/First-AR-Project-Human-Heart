using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloodPressureController : MonoBehaviour
{
    public Text bloodPressureText; // Reference to the UI Text component
    private int systolicPressure = 120; // Initial systolic pressure
    private int diastolicPressure = 80; // Initial diastolic pressure

    private int maxSystolicPressure = 140; // Maximum systolic pressure
    private int maxDiastolicPressure = 90; // Maximum diastolic pressure

    private int minSystolicPressure = 90; // Minimum systolic pressure
    private int minDiastolicPressure = 60; // Minimum diastolic pressure

    private bool isIncreasing = true; // Flag to track if blood pressure is increasing or decreasing

    void Start()
    {
        // Find and assign the UI Text component
        bloodPressureText = GetComponentInChildren<Text>();

        // If UI Text component is not found, log an error
        if (bloodPressureText == null)
        {
            Debug.LogError("UI Text component not found!");
        }
        else
        {
            // Start the blood pressure simulation
            InvokeRepeating("UpdateBloodPressure", 0f, 1f); // Update blood pressure every second
        }
    }

    void UpdateBloodPressure()
    {
        // Increase or decrease blood pressure based on the current trend
        if (isIncreasing)
        {
            systolicPressure++;
            diastolicPressure++;
        }
        else
        {
            systolicPressure--;
            diastolicPressure--;
        }

        // Check if blood pressure is within the allowable range
        if (systolicPressure > maxSystolicPressure || diastolicPressure > maxDiastolicPressure)
        {
            isIncreasing = false;
        }
        else if (systolicPressure < minSystolicPressure || diastolicPressure < minDiastolicPressure)
        {
            isIncreasing = true;
        }

        // Update the displayed blood pressure text using UI Text
        if (bloodPressureText != null)
        {
            bloodPressureText.text = "Blood Pressure: " + systolicPressure + "/" + diastolicPressure + " mmHg";
        }
    }
}

