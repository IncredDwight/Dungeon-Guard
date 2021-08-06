using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
public class PlayerShoot : MonoBehaviour
{ 
    [SerializeField] private GameObject _projectilePrefab;
    [SerializeField] private Transform _projectileSpawn;

    [SerializeField] private float _fireRate;
    private float _nextFire;

    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if(_playerInput.GetShootKey() && Time.time > _nextFire)
        {
            _nextFire = Time.time + _fireRate;
            Instantiate(_projectilePrefab, _projectileSpawn.transform.position, Quaternion.identity);
        }
    }

}
