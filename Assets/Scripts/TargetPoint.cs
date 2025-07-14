using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPoint : MonoBehaviour
{
    [SerializeField] private Vector3 _apoint = new Vector3();
    [SerializeField] private Vector3 _bpoint = new Vector3();
    [SerializeField] private float _speed;
    public Vector3 Position => transform.position;
    private float _offset = 0.01f;
    private bool _isGoToB = true;

    void Update()
    {
        if (_isGoToB)
        {
            transform.position = Vector3.MoveTowards(transform.position, _bpoint, _speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, _apoint, _speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, _apoint) < _offset && _isGoToB != true)
        {
            _isGoToB = true;
        }
        else if(Vector3.Distance(transform.position, _bpoint) < _offset && _isGoToB)
        {
            _isGoToB = false;
        }
    }
}
