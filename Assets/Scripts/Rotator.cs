using DG.Tweening;

public class Rotator : BaseTransformTween
{
    private void Start()
    {
        transform.DORotate(Vector3, Duration, RotateMode.FastBeyond360).
            SetEase(Ease.Linear).
            SetLoops(Repeats, LoopType);
    }
}
