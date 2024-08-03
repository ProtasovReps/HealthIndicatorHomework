using UnityEngine;
using UnityEngine.UI;

public class DamageButton : MonoBehaviour, IHealthInteractable
{
    [SerializeField] private Button _button;
    [SerializeField, Min(1)] private int _damage;

    private Health _playerHealth;

    public EffectTypes EffectType => EffectTypes.Damage;

    private void OnEnable()
    {
        _button.onClick.AddListener(ApplyEffect);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ApplyEffect);
    }

    public void Initialize(Health health) => _playerHealth = health;
 
    public void ApplyEffect() => _playerHealth.TakeDamage(_damage, EffectType);
}