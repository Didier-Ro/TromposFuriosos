using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody _rigidBody = default;
    [SerializeField] private float _speed = 5;
    [SerializeField] private Animator _animator = default;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    { 
       _animator.SetFloat("Horizontal", Input.acceleration.x);
       _animator.SetFloat("Vertical", Input.acceleration.z);
    }

    private void FixedUpdate()
    {
        _rigidBody.velocity = new Vector3(Input.acceleration.x * _speed, _rigidBody.velocity.y, -Input.acceleration.z * _speed);
    }
}
