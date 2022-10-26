using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    [SerializeField] private string _objectTag = default;
    [SerializeField] private NavMeshController _navMeshController = default;
    [SerializeField] private GameObject _powerUpEffectParticle = default;
    [SerializeField] private GameObject _thunderParticleEffect = default;
    [SerializeField] private AudioClip _thunder;
        private void Start()
    {
        _objectTag = gameObject.tag;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(("Damage")))
        {
            AudioManager.Instance.SFXSelection(_thunder, .5f);
            collision.gameObject.SetActive(false);
            gameObject.tag = "MakeDamage";
            _thunderParticleEffect.SetActive(true);
            _powerUpEffectParticle.SetActive(true);
            _navMeshController._isPoweUpActive = false;
            StartCoroutine(PowerUpEffect());
        }
    }

    IEnumerator PowerUpEffect()
    {
        yield return new WaitForSeconds(10f);
        gameObject.tag = _objectTag;
        _powerUpEffectParticle.SetActive(false);
        _thunderParticleEffect.SetActive(false);
    }
}
