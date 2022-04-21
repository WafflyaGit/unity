using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation = new Vector3(1, 1, 0);
    [SerializeField] private float _speed = 2.0f;
    [SerializeField] private float _maxScale = 1.2f;

    private void FixedUpdate()
    {
        transform.Rotate(_rotation * _speed * 100 * Time.deltaTime);

        if (transform.localScale.x <= _maxScale && transform.localScale.y <= _maxScale && transform.localScale.z <= _maxScale)
            transform.localScale = new Vector3(transform.localScale.x + 0.001f * _speed, transform.localScale.y + 0.001f * _speed, transform.localScale.z + 0.001f * _speed);

    }
}
