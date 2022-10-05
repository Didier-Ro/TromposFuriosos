using System;
using System.Collections;
using Unity.VisualScripting;
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
            collision.gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.tag = "MakeDamage";
            _navMeshController._isPoweUpActive = false;
            StartCoroutine(PowerUpEffect());
        }
    }

    IEnumerator PowerUpEffect()
    {
        yield return new WaitForSeconds(10f);
        gameObject.tag = _objectTag;
    }
}
