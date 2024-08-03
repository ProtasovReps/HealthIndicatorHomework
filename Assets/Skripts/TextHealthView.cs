using TMPro;
using UnityEngine;

public class TextHealthView : HealthView
{
    [SerializeField] private TextMeshProUGUI _text;

    protected override void SetValue()
    {
        string message = $"{Health.Value} / {Health.MaxValue}";

        _text.text = message;
    }
}
