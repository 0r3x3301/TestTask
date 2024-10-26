using UnityEngine;

public class InputMove : MonoBehaviour
{
    [SerializeField] private Transform _cameraTrensform;
    [SerializeField] private float _speed = 3f;
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var direction = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        transform.Translate(direction * _speed * Time.deltaTime);
    }
}
