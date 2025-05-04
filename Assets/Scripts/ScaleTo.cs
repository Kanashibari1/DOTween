using DG.Tweening;
using UnityEngine;

public class ScaleTo : MonoBehaviour
{
    private Vector3 _scale = new(2, 2, 2);

    private LoopType _loopType = LoopType.Yoyo;

    private readonly int _duration = 1;
    private readonly int _repeats = -1;

    private void Start()
    {
        transform.DOScale(_scale, _duration).
            SetLoops(_repeats, _loopType);
    }
}
