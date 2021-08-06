using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private KeyCode _shootKey = KeyCode.Mouse0;

    private float _movementDirection;

    private void Update()
    {
        _movementDirection = Input.GetAxisRaw("Vertical");
    }

    public float GetMovementDirection()
    {
        return _movementDirection;
    }

    public bool GetShootKey()
    {
        return Input.GetKey(_shootKey);
    }
}
