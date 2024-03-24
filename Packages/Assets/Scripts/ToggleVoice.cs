using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleVoiceRecording : MonoBehaviour
{
    public AudioClip voiceClip; // Reference to the audio clip to play
    private AudioSource audioSource; // Reference to the AudioSource component

    private bool isRecordingPlaying = false; // Flag to track if the recording is currently playing

    void Start()
    {
        // No initialization in Start method, AudioSource will be initialized when the button is clicked
    }

    public void ToggleVoice()
    {
        // Toggle the flag
        isRecordingPlaying = !isRecordingPlaying;

        // If audio source is not initialized, do it now
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.clip = voiceClip;
        }

        // Toggle audio playback based on the flag
        if (isRecordingPlaying)
        {
            // Start playing the recording
            audioSource.Play();
        }
        else
        {
            // Stop playing the recording
            audioSource.Stop();
        }
    }
}
