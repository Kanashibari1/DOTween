using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : BaseTweenAnimation
{
    [SerializeField] private Text _text;

    private readonly string _text1 = "������ ������";
    private readonly string _text2 = "\n����������";
    private readonly string _text3 = "�����";
    private readonly bool _richTextEnabled = true;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText(_text1, Duration));
        sequence.Append(_text.DOText(_text2, Duration).SetRelative());
        sequence.Append(_text.DOText(_text3, Duration, _richTextEnabled, ScrambleMode.All));
    }
}