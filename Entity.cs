using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _damage;

    protected int Damage => _damage;

    private int _currentHealth;

    private void Awake()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            if ((_currentHealth -= damage) < 0)
            {
                Destroy(gameObject);
            }
        }
    }

    public void Heal(int addingHealth)
    {
        _currentHealth += addingHealth;
    
        if (_currentHealth > _maxHealth)
            _currentHealth = _maxHealth;
    }
}
