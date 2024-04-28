using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _sprite;

    private void Start()
    {
        StartCoroutine(FadeIn());
    }

    private IEnumerator FadeIn()
    {
        var color = _sprite.color;

        for (int i = 0; i < 255; i++)
        {
            color.a = 1 - (1 / 255f * i);
            _sprite.color = color;

            Debug.Log(color.a);
            yield return null;
        }
    }
}
