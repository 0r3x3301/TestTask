using UnityEngine;

public class InputRotation : MonoBehaviour
{
    [SerializeField] private float _sensitivity = 0.2f;
    [SerializeField] private Transform _playerTransform;
    private float _cameraVerticalRotation = 0;
    private void LateUpdate()
    {
        float inputX = Input.GetAxis("Mouse X") * _sensitivity;
        float inputY = Input.GetAxis("Mouse Y") * _sensitivity;

        _cameraVerticalRotation -= inputY;
        _cameraVerticalRotation = Mathf.Clamp(_cameraVerticalRotation, -90f, 90f);
        transform.localEulerAngles = Vector3.right * _cameraVerticalRotation;

        _playerTransform.Rotate(Vector3.up * inputX);
    }
}
