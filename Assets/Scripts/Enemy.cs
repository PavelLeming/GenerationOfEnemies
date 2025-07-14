using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 5f;

    private void Update()
    {
        transform.Translate(_speed * Vector3.forward * Time.deltaTime);
    }
}
