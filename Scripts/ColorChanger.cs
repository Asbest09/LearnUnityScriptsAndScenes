using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _sprite;
    [SerializeField] private float _duration;
    [SerializeField] private Color _targetColor;

    private float _runningTime;
    private Color _startColor;

    private void Start()
    {
        _startColor = _sprite.color;
    }

    private void Update()
    {
        
        
        if(_runningTime <= _duration)
        {
            _runningTime += Time.deltaTime;

            float normalizeRunningTime = _runningTime / _duration;

            _sprite.color = Color.Lerp(_startColor, _targetColor, normalizeRunningTime);
        }
    }
}
