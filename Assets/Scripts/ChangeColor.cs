using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Color _color;

    private SpriteRenderer _spriteRenderer;
    private readonly int _duration = 3;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _spriteRenderer.DOColor(_color, _duration);
    }
}
