using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private float _movementAnimationSpeed;

    private void Start()
    {
        _animator.SetFloat("MovemntSpeed", _movementAnimationSpeed);
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
            _animator.SetTrigger("Attack");

        if (Input.GetMouseButton(1))
            _animator.SetBool("IsMoved", true);
        else
            _animator.SetBool("IsMoved", false);
    }
}
