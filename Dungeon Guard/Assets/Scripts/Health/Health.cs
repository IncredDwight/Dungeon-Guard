using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Health : MonoBehaviour, ITakeDamage
{
    [SerializeField] private float _maxHealth;
    private float _health;

    private void Awake()
    {
        _health = _maxHealth;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
            Die();
    }

    protected abstract void Die();
}
