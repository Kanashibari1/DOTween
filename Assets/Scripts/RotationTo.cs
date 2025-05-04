using DG.Tweening;
using UnityEngine;

public class RotationTo : MonoBehaviour
{
    private Vector3 _rotation = new(0, 360, 0);

    private LoopType _loopType = LoopType.Restart;

    private readonly int _duration = 1;
    private readonly int _repeats = -1;

    private void Start()
    {
        transform.DORotate(_rotation, _duration, RotateMode.FastBeyond360).
            SetEase(Ease.Linear).
            SetLoops(_repeats, _loopType);
    }
}
