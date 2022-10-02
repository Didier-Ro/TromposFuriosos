using System;
using UnityEngine;
using UnityEngine.Events;

public class MakeDamage : MonoBehaviour
{
    [SerializeField] private int _powerDamage = 10;
    [SerializeField] private string _tagToCompare = default;
    [SerializeField] private UnityEvent OnCollision = default;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(_tagToCompare))
        {
            Health health = collision.gameObject.GetComponent<Health>();
            if (health != null)
            {
                health.ReceiveDamage(_powerDamage);
                OnCollision?.Invoke();
            }
        }
    }
}