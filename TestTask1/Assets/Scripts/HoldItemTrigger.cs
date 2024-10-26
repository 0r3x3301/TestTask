using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HoldItemTrigger : MonoBehaviour
{
    [SerializeField] private Transform[] _points;

    private List<Transform> _freePoints;
    private List<Transform> _takedPoints;

    public static event Action OnTake;
    

    private void Awake()
    {
        _freePoints = _points.ToList();
        _takedPoints = new List<Transform>();
        Debug.Log(_freePoints.Count);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 3 && _freePoints.Count > 0)
        {
            OnTake?.Invoke();
            collision.transform.parent = _freePoints[0];
            collision.transform.position = _freePoints[0].position;
            collision.rigidbody.isKinematic = true;
            _takedPoints.Add(_freePoints[0]);
            _freePoints.RemoveAt(0);
        }
        else Debug.Log(_freePoints.Count);

    }

}
