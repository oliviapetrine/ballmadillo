using UnityEngine;
using UnityEngine.UI;

public class CustomColorPicker : MonoBehaviour
{
    public Image colorSelectionImage;
    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;

    private Color currentColor;

    void Start()
    {
        currentColor = Color.white;
        UpdateColor();
    }

    public void OnRedSliderValueChanged(float value)
    {
        currentColor.r = value;
        UpdateColor();
    }

    public void OnGreenSliderValueChanged(float value)
    {
        currentColor.g = value;
        UpdateColor();
    }

    public void OnBlueSliderValueChanged(float value)
    {
        currentColor.b = value;
        UpdateColor();
    }

    private void UpdateColor()
    {
        colorSelectionImage.color = currentColor;
    }
}
