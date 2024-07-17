using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Dummy : MonoBehaviour
{

    public Slider slider;

    public float sliderValue;
    public float minValue = -100;
    public float maxValue = 100;
    public float result = 0;


    private void Start()
    {
        slider.minValue = 0;
        slider.maxValue = 1;
        slider.value = 0;

        slider.onValueChanged.AddListener(SliderPositiveRange);
    }

    private void SliderNegativeWithPositiveRange(float value)
    {
        sliderValue = value;
        if (value < minValue)
        {
            value = minValue;

        }else if (value > maxValue)
        {
            value = maxValue;
        }

        result = (value * (maxValue - minValue) + minValue);
    }


    private void SliderPositiveRange(float value)
    {
        sliderValue = value;
        result = (value * (maxValue - minValue) + minValue);
        Debug.Log(result);
    }
}
