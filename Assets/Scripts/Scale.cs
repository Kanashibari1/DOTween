using DG.Tweening;

public class Scale : Base
{
    private void Start()
    {
        transform.DOScale(Vector3, Duration).
            SetLoops(Repeats, LoopType);
    }
}
