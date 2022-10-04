using System;
using System.Collections;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [SerializeField] private float _lifeTime = 8f;
    [SerializeField] private NavMeshController _navMeshController = default;
    void Start()
    {
        StartCoroutine(DestroObject());
    }
    

    IEnumerator DestroObject()
    {
        yield return new WaitForSeconds(_lifeTime);
        _navMeshController._isPoweUpActive = false;
        Destroy(gameObject);
    }
}