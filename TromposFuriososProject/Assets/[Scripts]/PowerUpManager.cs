using UnityEngine;
using Random = UnityEngine.Random;

public class PowerUpManager : MonoBehaviour
{
    [SerializeField] private NavMeshController _navMeshController = default;
    [SerializeField] private GameObject [] arraySpawners;
    private bool _powerUpSpawned = false;
    public int spawnerNumber = 0; 
    [SerializeField] private GameManager _gameManager;
    

    private void Start()
    {
        InvokeRepeating("Spawner",5,30);
        InvokeRepeating("TurnOffSpawner",20,30);
    }
    
    void Spawner()
    {
        spawnerNumber = Random.Range(0 , 4);
        arraySpawners[spawnerNumber].SetActive(true);
        arraySpawners[spawnerNumber].GetComponent<MeshRenderer>().enabled = true;
        _gameManager.PowerUpOn();
        _navMeshController._isPoweUpActive = true;
    }
    void TurnOffSpawner()
    {
        arraySpawners[spawnerNumber].SetActive(false);
        _gameManager.PowerUpOff();
        _navMeshController._isPoweUpActive = false;
    }
    
    void PowerUp()
    {
        _navMeshController._isPoweUpActive = false;
    }
    
    
}