using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class PowerUpManager : MonoBehaviour
{
    [SerializeField] private NavMeshController _navMeshController = default;
    [SerializeField] private GameObject [] arraySpawners;
    private bool _powerUpSpawned = false;
    public int spawnerNumber = 0;
    

    private void Start()
    {
        InvokeRepeating("Spawner",5,30);
        InvokeRepeating("TurnOffSpawner",20,30);
    }
    
    void Spawner()
    {
        spawnerNumber = Random.Range(0 , 4);
        arraySpawners[spawnerNumber].SetActive(true);
        _navMeshController._isPoweUpActive = true;
    }
    void TurnOffSpawner()
    {
        arraySpawners[spawnerNumber].SetActive(false);
        _navMeshController._isPoweUpActive = false;
    }
    
    void PowerUp()
    {
        _navMeshController._isPoweUpActive = false;
    }
    
    
}