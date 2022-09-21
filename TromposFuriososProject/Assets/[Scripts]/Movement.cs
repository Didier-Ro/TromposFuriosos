using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    void Update()
    { 
       transform.Translate(Input.acceleration.x * _speed * Time.deltaTime, 0, -Input.acceleration.z * _speed * Time.deltaTime);
    }
}
