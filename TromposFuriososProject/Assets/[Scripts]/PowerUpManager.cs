using System.Collections;
using UnityEngine;
public class PowerUpManager : MonoBehaviour
{
    [SerializeField] private NavMeshController _navMeshController = default;
    [SerializeField] private GameObject _powerUpPrefab = default;
    [SerializeField] private float yPosition = 16f;
    [SerializeField] private float xPosition = 85f;
    [SerializeField] private float xNegativePosition = -72;
    [SerializeField] private float zPosition = 50f;
    [SerializeField] private float zNegativePosition = -50;
    private bool _powerUpSpawned = false;
    
    void Update()
    {
        if (_powerUpSpawned == false)
        {
            StartCoroutine(SpawningPowerUps());
        }
    }

    IEnumerator SpawningPowerUps()
    {
        _powerUpSpawned = true;
        yield return new WaitForSeconds(5f);
        Instantiate(_powerUpPrefab, new Vector3(Random.Range(xNegativePosition, xPosition), yPosition, Random.Range(zNegativePosition, zPosition)), Quaternion.identity);
        _navMeshController._isPoweUpActive = true;
        yield return new WaitForSeconds(15f);
        _powerUpSpawned = false;
    }
}