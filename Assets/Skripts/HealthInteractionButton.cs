using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class HealthInteractionButton : MonoBehaviour
{
    private Button _button;

    protected Health Health { get; private set; }

    private void OnEnable()
    {
        if (_button != null)
            _button.onClick.AddListener(ApplyEffect);
    }

    private void OnDisable()
    {
        if (_button != null)
            _button.onClick.RemoveListener(ApplyEffect);
    }

    public void Initialize(Health health)
    {
        _button = GetComponent<Button>();
        Health = health;

        _button.onClick.AddListener(ApplyEffect);
    }

    protected abstract void ApplyEffect();
}
