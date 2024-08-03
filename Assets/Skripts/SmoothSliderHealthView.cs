using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothSliderHealthView : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField, Range(0.002f, 0.01f)] private float _valueChangeSpeed;

    private Health _health;
    private Coroutine _coroutine;

    private void OnEnable()
    {
        if (_health != null)
            _health.AmountChanged += StartSettingSliderValue;
    }

    private void OnDisable()
    {
        if (_health != null)
            _health.AmountChanged -= StartSettingSliderValue;
    }

    public void Initialize(Health health)
    {
        _health = health;
        _slider.interactable = false;
        _health.AmountChanged += StartSettingSliderValue;

        StartSettingSliderValue();
    }

    private void StartSettingSliderValue()
    {
        if (_coroutine == null)
            _coroutine = StartCoroutine(SetSliderValueSmoothly());
    }

    private IEnumerator SetSliderValueSmoothly()
    {
        float valueChangeSpeed = _slider.maxValue * _valueChangeSpeed;

        while (_slider.value != GetNewSliderValue())
        {
            _slider.value = Mathf.MoveTowards(_slider.value, GetNewSliderValue(), valueChangeSpeed);
            yield return null;
        }

        _coroutine = null;
    }

    private float GetNewSliderValue()
    {
        float healthRatio = (float)_health.Value / _health.MaxValue;
        float newSliderValue = _slider.maxValue * healthRatio;
        return newSliderValue;
    }
}
