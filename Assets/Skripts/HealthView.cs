using UnityEngine;

public abstract class HealthView : MonoBehaviour
{
    protected Health Health { get; private set; }

    private void OnEnable()
    {
        if (Health != null)
            Health.AmountChanged += SetValue;
    }

    private void OnDisable()
    {
        if (Health != null)
            Health.AmountChanged -= SetValue;
    }

    public void Initialize(Health health)
    {
        Health = health;
        Health.AmountChanged += SetValue;

        SetValue();
    }

    protected abstract void SetValue();
}