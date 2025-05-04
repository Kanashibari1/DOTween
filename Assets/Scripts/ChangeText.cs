using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text text;

    private readonly int _duration = 2;

    private WaitForSeconds _delay = new WaitForSeconds(2);

    void Start()
    {
        StartCoroutine(Change());
    }

    private IEnumerator Change()
    {
        text.DOText("Замена текста", _duration);
        yield return _delay;
        text.DOText("\nДополнение", _duration).SetRelative();
        yield return _delay;
        text.DOText("Замена текста", _duration, true, ScrambleMode.All);
    }
}