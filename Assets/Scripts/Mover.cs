using DG.Tweening;

public class Mover : Base
{
    private void Start()
    {
        transform.DOMove(Vector3, Duration).
            SetLoops(Repeats, LoopType);
    }
}
