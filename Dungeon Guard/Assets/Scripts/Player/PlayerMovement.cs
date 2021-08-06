using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerInput))]
public class PlayerMovement : MonoBehaviour
{
     private Rigidbody2D _rigidbody2D;
     private PlayerInput _playerInput;

    [SerializeField] private float _movementSpeed;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _playerInput = GetComponent<PlayerInput>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, _playerInput.GetMovementDirection() * _movementSpeed);
    }


}
