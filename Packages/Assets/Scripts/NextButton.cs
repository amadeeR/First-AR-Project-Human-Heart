using UnityEngine;
using UnityEngine.UI;


public class NextButton : MonoBehaviour
{
    public Text[] descriptions; // Array of Text components for different descriptions
    private int currentDescriptionIndex = 0;

    private void Start()
    {
        // Initially, display the first description
        ShowDescription(currentDescriptionIndex);
    }

    public void Next()
    {
        // Increment the index to show the next description
        currentDescriptionIndex = (currentDescriptionIndex + 1) % descriptions.Length;
        ShowDescription(currentDescriptionIndex);
    }

    private void ShowDescription(int index)
    {
        // Hide all descriptions
        foreach (Text description in descriptions)
        {
            description.gameObject.SetActive(false);
        }

        // Show the description at the given index
        descriptions[index].gameObject.SetActive(true);
    }
}
