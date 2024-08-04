using UnityEngine;
using UnityEngine.UI;

public class RawSliderStatView : StatView
{
    [SerializeField] private Slider _slider;

    protected override void SetValue()
    {
        float healthRatio = (float)Stat.GetValue()/ Stat.GetMaxValue();
        float newSliderValue = _slider.maxValue * healthRatio;

        _slider.value = newSliderValue;
    }
}
