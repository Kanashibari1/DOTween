using DG.Tweening;
using UnityEngine;

public class MoveRotationScale : MonoBehaviour
{
    private Vector3 _move = new(5, 0, 6);
    private Vector3 _rotation = new(0, 360, 0);
    private Vector3 _scale = new(2, 2, 2);

    private LoopType _loopType = LoopType.Yoyo;
    private LoopType _rotationType = LoopType.Restart;

    private readonly int _duration = 1;
    private readonly int _repeats = -1;

    private void Start()
    {
        transform.DOMove(_move, _duration).
            SetLoops(_repeats, _loopType);
        transform.DORotate(_rotation, _duration, RotateMode.FastBeyond360).
            SetLoops(_repeats, _rotationType).
            SetEase(Ease.Linear);
        transform.DOScale(_scale, _duration).
            SetLoops(_repeats, _loopType);
    }
}
