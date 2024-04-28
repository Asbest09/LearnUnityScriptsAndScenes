using UnityEngine;

public class AudiioPlayer : MonoBehaviour
{
    [SerializeField] private EndPoint _endPoint;
    [SerializeField] private AudioSource _audioSource;

    private void OnEnable()
    {
        _endPoint.Reached += PlaySound;
    }

    private void OnDisable()
    {
        _endPoint.Reached -= PlaySound;
    }

    private void PlaySound()
    {
        _audioSource.Play();
    }
}
