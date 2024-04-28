using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndPoint : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _sprite;
    [SerializeField] private Color _reachedColor;

    public bool IsReached { get; private set; } = false;

    public event Action Reached;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out FreeWayCheaker _))
        {
            _sprite.color = _reachedColor;
            IsReached = true;
            Reached?.Invoke();
        }
    }
}
