using DG.Tweening;

public class Mover : BaseTransformTween
{
    private void Start()
    {
        transform.DOMove(Vector3, Duration).
            SetLoops(Repeats, LoopType);
    }
}
