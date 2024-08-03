using UnityEngine;
using UnityEngine.UI;

public class RawSliderHealthView : HealthView
{
    [SerializeField] private Slider _slider;

    protected override void SetValue()
    {
        float healthRatio = (float)Health.Value / Health.MaxValue;
        float newSliderValue = _slider.maxValue * healthRatio;

        _slider.value = newSliderValue;
    }
}
