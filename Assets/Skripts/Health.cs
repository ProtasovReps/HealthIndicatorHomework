using System;
using UnityEngine;

public class Health : IValueShareable
{
    private ArgumentChecker _argumentChecker;
    private int _value;
    private int _maxValue;

    public Health()
    {
        _argumentChecker = new ArgumentChecker();
        _maxValue = 5;
        _value = _maxValue;
    }

    public event Action ValueChanged;

    public void TakeDamage(int damage)
    {
        if (_argumentChecker.CheckPositiveValue(damage))
        {
            _value -= Mathf.Clamp(damage, 0, _value);

            ValueChanged?.Invoke();
        }
    }

    public void Heal(int healAmount)
    {
        if (_argumentChecker.CheckPositiveValue(healAmount))
        {
            _value += Mathf.Clamp(healAmount, 0, _maxValue - _value);

            ValueChanged?.Invoke();
        }
    }

    public int GetValue() => _value;

    public int GetMaxValue() => _maxValue;
}
