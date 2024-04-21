using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private int _speed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-_speed * Time.deltaTime, 0, 0);
        }
    }
}
