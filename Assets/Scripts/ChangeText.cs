using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text;

    private readonly int _duration = 3;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText("������ ������", _duration));
        sequence.Append(_text.DOText("\n����������", _duration).SetRelative());
        sequence.Append(_text.DOText("������ ������", _duration, true, ScrambleMode.All));
    }
}