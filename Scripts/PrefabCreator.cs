using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCreator : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    private void Start()
    {
        GameObject obj = Instantiate(_prefab, new Vector3(1, 1, 0), Quaternion.identity, transform);
    }
}
