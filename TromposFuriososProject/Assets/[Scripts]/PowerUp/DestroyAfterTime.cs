using System;
using System.Collections;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [SerializeField] private float _lifeTime = 8f;
    [SerializeField] private NavMeshController _navMeshController = default;
    void Start()
    {
        Destroy(gameObject,10);
    }



}