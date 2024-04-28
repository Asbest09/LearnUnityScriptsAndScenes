using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeWayCheaker : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private ContactFilter2D _filter;

    private readonly RaycastHit2D[] _results = new RaycastHit2D[1];

    private void FixedUpdate()
    {
        var collisionsCount = _rigidbody.Cast(transform.right, _filter, _results, 20);

        if (collisionsCount > 0)
            _rigidbody.velocity = Vector3.zero; 
        else
            _rigidbody.velocity = transform.right * _speed;
    }
}
