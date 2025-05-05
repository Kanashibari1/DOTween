using DG.Tweening;

public class ScaleTo : Base
{
    private void Start()
    {
        transform.DOScale(_vector3, _duration).
            SetLoops(_repeats, _loopType);
    }
}
