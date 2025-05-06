using DG.Tweening;
using UnityEngine;

public class Base : MonoBehaviour
{
    [SerializeField] protected int Duration = 3;
    [SerializeField] protected Vector3 Vector3;
    [SerializeField] protected LoopType LoopType;

    protected readonly int Repeats = -1;
}