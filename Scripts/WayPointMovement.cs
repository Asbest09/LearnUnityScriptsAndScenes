using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointMovement : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private int _speed;

    private Transform[] _points;
    private int _currentPoint;

    private void Start()
    {
        _points = new Transform[_path.childCount];

        for(var i =0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i).transform;
        }
    }

    private void Update()
    {
        Transform target = _points[_currentPoint];

        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * _speed);

        if(target.position == transform.position)
        {
            _currentPoint++;

            if(_currentPoint >= _points.Length )
                _currentPoint = 0;
        }
    }
}
