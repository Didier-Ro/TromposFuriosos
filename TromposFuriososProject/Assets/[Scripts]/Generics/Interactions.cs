using System;
using System.Collections;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    [SerializeField] private string _objectTag = default;
    [SerializeField] private NavMeshController _navMeshController = default;

    private void Start()
    {
        _objectTag = gameObject.tag;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(("Damage")))
        {
            gameObject.tag = "MakeDamage";
            _navMeshController._isPoweUpActive = false;
            StartCoroutine(PowerUpEffect());
        }
    }

    IEnumerator PowerUpEffect()
    {
        yield return new WaitForSeconds(5f);
        gameObject.tag = _objectTag;
    }
}
