using DG.Tweening;
using UnityEngine;

public class BaseTransformTween : BaseTweenAnimation
{
    [SerializeField] protected Vector3 Vector3;
    [SerializeField] protected LoopType LoopType;

    protected readonly int Repeats = -1;
}
