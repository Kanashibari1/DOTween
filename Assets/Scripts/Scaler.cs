using DG.Tweening;

public class Scaler : BaseTransformTween
{
    private void Start()
    {
        transform.DOScale(Vector3, Duration).
            SetLoops(Repeats, LoopType);
    }
}
