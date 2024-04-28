using UnityEngine;
using UnityEngine.EventSystems;

public class Block : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _jumpForce;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("click");
        _rigidbody.AddForce(Vector3.up * _jumpForce);
    }
}
