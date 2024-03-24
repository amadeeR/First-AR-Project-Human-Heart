using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    public GameObject heartObject; // Reference to your heart object

    // Default rotation of the heart object
    private Quaternion defaultRotation = Quaternion.Euler(-0.961f, -343.944f, -0.277f);

    void Start()
    {
        // Add a listener to the button component
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(ResetHeartRotation);
    }

    public void ResetHeartRotation()
    {
        // Set the rotation of the heart object to the default rotation
        heartObject.transform.rotation = defaultRotation;
    }
}
