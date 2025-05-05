using DG.Tweening;

public class RotationTo : Base
{
    private void Start()
    {
        transform.DORotate(_vector3, _duration, RotateMode.FastBeyond360).
            SetEase(Ease.Linear).
            SetLoops(_repeats, _loopType);
    }
}
