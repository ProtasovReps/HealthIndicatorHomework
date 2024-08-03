using System;
using UnityEngine;

public class Health
{
    private ArgumentChecker _argumentChecker;

    public Health()
    {
        _argumentChecker = new ArgumentChecker();
        MaxValue = 5;
        Value = MaxValue;
    }

    public event Action AmountChanged;

    public int Value { get; private set; }
    public int MaxValue { get; private set; }

    public void TakeDamage(int damage)
    {
        if (_argumentChecker.CheckPositiveValue(damage))
        {
            Value -= Mathf.Clamp(damage, 0, Value);

            AmountChanged?.Invoke();
        }
    }

    public void Heal(int healAmount)
    {
        if (_argumentChecker.CheckPositiveValue(healAmount))
        {
            Value += Mathf.Clamp(healAmount, 0, MaxValue - Value);

            AmountChanged?.Invoke();
        }
    }
}
