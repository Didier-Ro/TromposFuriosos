using UnityEngine;
using Random = UnityEngine.Random;

public class PowerUpManager : MonoBehaviour
{
    [SerializeField] private NavMeshController _navMeshController = default;
    [SerializeField] private GameObject [] arraySpawners;
    private bool _powerUpSpawned = false;
    public int spawnerNumber = 0; 
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private AudioClip _spawn;
    

    private void Start()
    {
        InvokeRepeating("Spawner",5,30);
        InvokeRepeating("TurnOffSpawner",20,30);
    }
    
    void Spawner()
    {
        spawnerNumber = Random.Range(0 , 4);
        arraySpawners[spawnerNumber].SetActive(true);
        AudioManager.Instance.SFXSelection(_spawn, .5f);
        _navMeshController._isPoweUpActive = true;
        _gameManager.PowerUpOn();
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