using UnityEngine;

public class DamageButton : HealthInteractionButton
{
    [SerializeField, Min(1)] private int _damage;
 
    protected override void ApplyEffect() => Health.TakeDamage(_damage);
}