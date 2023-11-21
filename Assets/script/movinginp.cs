using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class movinginp : MonoBehaviour
{
    [SerializeField] private float _velocity = 3f;
    [SerializeField] private float _RotationSpeed = 10f;

    private Rigidbody2D _rigidbody2;
    void Start()
    {
        _rigidbody2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            _rigidbody2.velocity = Vector2.up * _velocity;
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = quaternion.Euler(0, 0, _rigidbody2.velocity.y * _RotationSpeed);
    }
}
