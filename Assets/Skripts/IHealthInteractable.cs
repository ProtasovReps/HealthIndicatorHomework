public interface IHealthInteractable
{
    public abstract EffectTypes EffectType { get; }

    public abstract void ApplyEffect();
}
