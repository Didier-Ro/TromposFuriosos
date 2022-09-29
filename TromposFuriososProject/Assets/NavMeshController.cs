using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{
    [SerializeField] private Transform _objective;
    [SerializeField] private NavMeshAgent _agent;
    
    void Start()
    {
        _agent= GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        _agent.destination = _objective.position;
    }
}
