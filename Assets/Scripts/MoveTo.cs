using UnityEngine;
using DG.Tweening;

public class MoveTo : MonoBehaviour
{
    private Vector3 _move = new(5, 0, 0);

    private LoopType _loopType = LoopType.Yoyo;

    private readonly int _duration = 1;
    private readonly int _repeats = -1;

    private void Start()
    {
        transform.DOMove(_move, _duration).
            SetLoops(_repeats, _loopType);
    }
}
