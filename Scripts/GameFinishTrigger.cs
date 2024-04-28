using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinishTrigger : MonoBehaviour
{
    private EndPoint[] _endPoints;

    private void OnEnable()
    {
        _endPoints = gameObject.GetComponentsInChildren<EndPoint>();

        foreach(EndPoint point in _endPoints)
            point.Reached += OnEndPointReached;
    }

    private void OnDisable()
    {
        foreach (EndPoint point in _endPoints)
            point.Reached -= OnEndPointReached;
    }

    private void OnEndPointReached()
    {
        foreach(EndPoint point in _endPoints)
        {
            if (point.IsReached == false)
                return;
        }

        Debug.Log("Finish");
    }
}
