using UnityEngine;
public class TakeHandler : MonoBehaviour
{
    [SerializeField] private Transform _takePointTransform;
    [SerializeField] private RaycastHandler _raycastHandler;
    Transform _takedItem = null;


    private void OnValidate()
    {
        _raycastHandler = GetComponentInChildren<RaycastHandler>();
    }

    private void OnEnable()
    {
        HoldItemTrigger.OnTake += SetItemNull;
    }

    private void OnDisable()
    {
        HoldItemTrigger.OnTake -= SetItemNull;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.E) && _raycastHandler.HitTransform != null)
        {
            _takedItem = _raycastHandler.HitTransform;
        }


        if (_takedItem != null) _takedItem.position = _takePointTransform.position;
    }

    private void SetItemNull()
    {
        _takedItem = null;
    }
}
