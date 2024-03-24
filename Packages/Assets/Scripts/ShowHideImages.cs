using UnityEngine;
using UnityEngine.UI;

public class ToggleImages : MonoBehaviour
{
    public Image atriumsImage; // Reference to the UI Image representing atriums
    public Image ventriclesImage; // Reference to the UI Image representing ventricles
    public Image atriumText; // Reference to the UI Image representing atrium text
    public Image ventricleText; // Reference to the UI Image representing ventricle text
    public Image arrow; // Reference to the UI Image representing arrow
    public Image arrow2; // Reference to the UI Image representing arrow2
    public Image image1; // Reference to the UI Image representing image 1
    public Image image2; // Reference to the UI Image representing image 2
    public Image image3; // Reference to the UI Image representing image 3
    public Image image4; // Reference to the UI Image representing image 4

    private bool imagesShown = false; // Flag to track if images are currently shown

    void Start()
    {
        // Initially, hide all images
        ToggleAllImagesVisibility(false);
    }

    public void ToggleImagesVisibility()
    {
        // Toggle the flag
        imagesShown = !imagesShown;

        // Toggle the visibility of all images based on the flag
        ToggleAllImagesVisibility(imagesShown);
    }

    private void ToggleAllImagesVisibility(bool visibility)
    {
        // Set visibility for each image
        atriumsImage.enabled = visibility;
        ventriclesImage.enabled = visibility;
        atriumText.enabled = visibility;
        ventricleText.enabled = visibility;
        arrow.enabled = visibility;
        arrow2.enabled = visibility;
        image1.enabled = visibility;
        image2.enabled = visibility;
        image3.enabled = visibility;
        image4.enabled = visibility;
    }
}
