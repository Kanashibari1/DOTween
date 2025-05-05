using DG.Tweening;

public class MoveTo : Base
{
    private void Start()
    {
        transform.DOMove(_vector3, _duration).
            SetLoops(_repeats, _loopType);
    }
}
