using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text text;

    private readonly int _duration = 3;

    private void Start()
    {
        Sequence mySequence = DOTween.Sequence();
        mySequence.Append(text.DOText("������ ������", _duration));
        mySequence.Append(text.DOText("\n����������", _duration).SetRelative());
        mySequence.Append(text.DOText("������ ������", _duration, true, ScrambleMode.All));
    }
}