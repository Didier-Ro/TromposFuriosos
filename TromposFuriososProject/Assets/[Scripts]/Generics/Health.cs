using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxHealt = 100;
    [SerializeField] private int _currentHealth = 100;
    [SerializeField] private Animator _animator = default;
    [SerializeField] private UnityEvent<int> OnReceiveDamage;
    [SerializeField] private UnityEvent OnZeroHealth;

    public int CurrentHealth
    {
        get => _currentHealth;
        set => _currentHealth = value;
    }

    public void ReceiveDamage(int damageAmount)
    {
        CurrentHealth -= damageAmount;
        OnReceiveDamage?.Invoke(_currentHealth);

        if (_currentHealth >= 100)
        {
            _animator.speed = 1;
        }

        if (_currentHealth <= 75)
        {
            _animator.speed = 0.75f;
        }

        if (_currentHealth <= 50)
        {
            _animator.speed = 0.5f;
        }

        if (_currentHealth <= 20)
        {
            _animator.speed = 0.1f;
        }
        
        if(CurrentHealth <= 0)
        {
            OnZeroHealth?.Invoke();
        }
    }

    private void OnEnable()
    {
        _currentHealth = _maxHealt;
    }
}
