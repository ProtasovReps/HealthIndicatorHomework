using UnityEngine;

public class CompositeRoot : MonoBehaviour
{
    [SerializeField] private TextHealthView _textHealthView;
    [SerializeField] private RawSliderHealthView _rawSliderHealthView;
    [SerializeField] private SmoothSliderHealthView _smoothSliderHealthView;
    [SerializeField] private DamageButton _damageButton;
    [SerializeField] private HealButton _healButton;

    private Health _health;

    private void Awake()
    {
        _health = new Health();

        _textHealthView.Initialize(_health);
        _rawSliderHealthView.Initialize(_health);
        _smoothSliderHealthView.Initialize(_health);
        _damageButton.Initialize(_health);
        _healButton.Initialize(_health);
    }
}
