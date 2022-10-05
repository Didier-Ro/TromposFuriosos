using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{
    public bool _isPoweUpActive = default;
    [SerializeField] private GameObject _objective;
    [SerializeField] private GameObject pu1;
    [SerializeField] private GameObject pu2;
    [SerializeField] private GameObject pu3;
    [SerializeField] private GameObject pu4;
    [SerializeField] private GameObject pu5;
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private PowerUpManager _powerUpManager = default;
    
    void Start()
    {
        _agent= GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        if (_isPoweUpActive == false)
        {
            _agent.destination = _objective.transform.position;    
        }
        else switch (_powerUpManager.spawnerNumber)
        {
            case 0:
                _agent.destination = pu1.transform.position;
                break;    
            case 1:
                _agent.destination = pu2.transform.position;
                break;  
            case 2:
                _agent.destination = pu3.transform.position;
                break;  
            case 3:
                _agent.destination = pu4.transform.position;
                break;  
            case 4:
                _agent.destination = pu5.transform.position;
                break;

        }
    }

    public void ChangeActive()
    {
        _isPoweUpActive = !_isPoweUpActive;
    }

    public void Prueba()
    {
        _isPoweUpActive = false;
        print("Hola");
    }

    public void ChangePath()
    {
        _objective=GameObject.FindGameObjectWithTag("Damage");
    }

}
