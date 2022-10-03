using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{
    [SerializeField] private bool _isPoweUpActive;
    [SerializeField] private Transform _objective;
    [SerializeField] private Transform _objective2;
    [SerializeField] private NavMeshAgent _agent;
    
    void Start()
    {
        _agent= GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        if(_isPoweUpActive)
        {
            _agent.destination = _objective.position;
        }
        else
        {
            _agent.destination = _objective2.position;
        }
        
    }
}
