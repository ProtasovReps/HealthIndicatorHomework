using UnityEngine;
using UnityEngine.UI;

public class HealButton : MonoBehaviour, IHealthInteractable
{
    [SerializeField] private Button _button;
    [SerializeField, Min(1)] private int _healAmount;

    private Health _playerHealth;

    public EffectTypes EffectType => EffectTypes.Heal;

    private void OnEnable()
    {
        _button.onClick.AddListener(ApplyEffect);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ApplyEffect);
    }

    public void Initialize(Health health) => _playerHealth = health;

    public void ApplyEffect() => _playerHealth.Heal(_healAmount, EffectType);
}
