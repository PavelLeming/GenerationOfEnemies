using UnityEngine;

public class Enemy : MonoBehaviour
{
    private TargetPoint _targetPoint;
    private float _speed = 5f;

    public void Initialize(Vector3 position, TargetPoint targetPoint)
    {
        transform.position = position;
        _targetPoint = targetPoint;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPoint.Position, _speed * Time.deltaTime);
    }
}
