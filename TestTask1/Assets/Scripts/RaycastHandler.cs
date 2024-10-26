using UnityEngine;

public class RaycastHandler : MonoBehaviour
{
    [SerializeField] private float _rayDistance;
    [SerializeField] private LayerMask _raycastLayers;
    private Transform _hitTransform;


    public Transform HitTransform => _hitTransform;
    private void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, _rayDistance, _raycastLayers))
        {
            _hitTransform = hit.transform;
        }
        else
        {
            _hitTransform = null;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + transform.forward * _rayDistance);
    }
}
