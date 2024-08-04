using TMPro;
using UnityEngine;

public class TextStatView : StatView
{
    [SerializeField] private TextMeshProUGUI _text;

    protected override void SetValue()
    {
        string message = $"{Stat.GetValue()} / {Stat.GetMaxValue()}";

        _text.text = message;
    }
}
