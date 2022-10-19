using System;
using UnityEngine;
using UnityEngine.Events;

public class MakeDamage : MonoBehaviour
{
    [SerializeField] private int _powerDamage = 10;
    [SerializeField] private string _tagToCompare = default;
    [SerializeField] private UnityEvent OnCollision = default;
    [SerializeField] private GameObject _impactParticleEffect = default;

    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 position = contact.point;
        Instantiate(_impactParticleEffect, position, rotation);
        if (collision.gameObject.CompareTag(_tagToCompare) && gameObject.CompareTag("MakeDamage"))
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