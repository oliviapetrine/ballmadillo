using UnityEngine;
using UnityEngine.UI;

public class ChangeMaterialColor : MonoBehaviour
{
    public Material materialToChange;
    public CustomColorPicker colorPicker;

    void Start()
    {
        // Set the material color to the initial color of the color picker
        materialToChange.color = colorPicker.colorSelectionImage.color;
    }

    void Update()
    {
        // Get the current color of the color picker
        Color newColor = colorPicker.colorSelectionImage.color;

        // Change the material color to the new color
        materialToChange.color = newColor;
    }
}
