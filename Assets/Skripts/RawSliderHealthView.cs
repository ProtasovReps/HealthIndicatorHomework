using UnityEngine;
using UnityEngine.UI;

public class RawSliderHealthView : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private Health _health;

    private void OnEnable()
    {
        if (_health != null)
            _health.AmountChanged += SetSliderValue;
    }

    private void OnDisable()
    {
        if (_health != null)
            _health.AmountChanged -= SetSliderValue;
    }

    public void Initialize(Health health)
    {
        _health = health;
        _slider.interactable = false;
        _health.AmountChanged += SetSliderValue;

        SetSliderValue();
    }

    private void SetSliderValue()
    {
        float healthRatio = (float)_health.Value / _health.MaxValue;
        float newSliderValue = _slider.maxValue * healthRatio;

        _slider.value = newSliderValue;
    }
}
