using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateAndScaleSlider : MonoBehaviour
{
    public Slider rotateSlider;
    public Slider scaleSlider;

    private Transform _transform;

    void Start()
    {
        _transform = this.transform; // Cache transform for performance
    }

    // Update is called once per frame
    void Update()
    {
        float angleSliderNumber = rotateSlider.value * 10f;
        _transform.rotation = Quaternion.Euler(0f, angleSliderNumber, 0f);

        float scaleSliderNumber = scaleSlider.value; // Correctly get the slider value
        Vector3 scale = new Vector3(scaleSliderNumber, scaleSliderNumber, scaleSliderNumber);
        _transform.localScale = scale;

        // Debugging logs
        Debug.Log("Rotation Angle: " + angleSliderNumber);
        Debug.Log("Scale Value: " + scaleSliderNumber);
    }
}