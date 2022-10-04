using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    private Rigidbody _rigidBody = default;
    [SerializeField] private float impulseForce = 10;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            _rigidBody.AddForce(transform.position - collision.gameObject.transform.position * impulseForce, ForceMode.Impulse);
        }
    }
}
