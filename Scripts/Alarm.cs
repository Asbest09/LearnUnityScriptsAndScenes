using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void OnMouseDown()
    {
        _animator.SetTrigger("Alarm");
    }
}
