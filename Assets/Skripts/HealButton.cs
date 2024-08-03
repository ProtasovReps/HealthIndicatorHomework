using UnityEngine;

public class HealButton : HealthInteractionButton
{
    [SerializeField, Min(1)] private int _healAmount;

    protected override void ApplyEffect() => Health.Heal(_healAmount);
}
