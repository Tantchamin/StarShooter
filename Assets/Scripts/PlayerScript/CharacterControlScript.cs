using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterControlScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody;

    [SerializeField] private float moveSpeed;

    private Vector2 moveDirection;

    [SerializeField] private InputActionReference move, fireNormal, fireSpecial;

    private void Update()
    {
        moveDirection = move.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

}
