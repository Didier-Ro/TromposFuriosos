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
        if (GameManager.Instance.IsGameRunning())
        {
           _animator.SetFloat("Horizontal", Input.acceleration.x);
           _animator.SetFloat("Vertical", Input.acceleration.z);
        }
    }

    private void FixedUpdate()
    {
        Vector3 tilt = Input.acceleration.normalized;
        tilt = Quaternion.Euler(-45, 0, 0) * tilt;
        if (GameManager.Instance.IsGameRunning())
        {
            _rigidBody.velocity = new Vector3(tilt.normalized.x * _speed, _rigidBody.velocity.y, -tilt.normalized.z * _speed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeadZone"))
        {
            GameManager.Instance.LoseGameOver();
        }
    }
}
