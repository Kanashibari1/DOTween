using DG.Tweening;
using UnityEngine;

public class Base : MonoBehaviour
{
    [SerializeField] protected int _duration = 3;
    [SerializeField] protected Vector3 _vector3;
    [SerializeField] protected LoopType _loopType;

    protected readonly int _repeats = -1;
}
