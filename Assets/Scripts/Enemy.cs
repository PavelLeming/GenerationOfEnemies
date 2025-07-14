using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 5f;

    public void Initialize(Vector3 position, Quaternion rotation)
    {
        transform.position = position;
        transform.rotation = rotation;
    }

    private void Update()
    {
        transform.Translate(_speed * Vector3.forward * Time.deltaTime);
    }
}
