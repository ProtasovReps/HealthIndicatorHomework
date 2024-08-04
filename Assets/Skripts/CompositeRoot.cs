using UnityEngine;

public class CompositeRoot : MonoBehaviour
{
    [SerializeField] private TextStatView _textHealthView;
    [SerializeField] private RawSliderStatView _rawSliderHealthView;
    [SerializeField] private SmoothSliderStatView _smoothSliderHealthView;
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
