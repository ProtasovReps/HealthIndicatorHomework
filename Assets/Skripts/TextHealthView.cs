using TMPro;
using UnityEngine;

public class TextHealthView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private Health _health;

    private void OnEnable()
    {
        if(_health != null)
            _health.AmountChanged += ShowHealth;
    }

    private void OnDisable()
    {
        if (_health != null)
            _health.AmountChanged -= ShowHealth;
    }

    public void Initialize(Health health)
    {
        _health = health;
        _health.AmountChanged += ShowHealth;

        ShowHealth();
    }

    public void ShowHealth()
    {
        string message = $"{_health.Value} / {_health.MaxValue}";

        _text.text = message;
    }
}
