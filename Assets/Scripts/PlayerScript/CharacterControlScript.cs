using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterControlScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;

    [SerializeField] private float moveSpeed;

    private PlayerControls _playerControl;

    private Vector2 moveDirection;

    private InputAction move, fireNormal, fireSpecial;

    //[SerializeField] private InputActionReference move, fireNormal, fireSpecial;

    private void Awake()
    {
        _playerControl = new PlayerControls();
    }

    private void OnEnable()
    {
        move = _playerControl.Player.Move;
        move.Enable();

        fireNormal = _playerControl.Player.FireNormal;
        fireNormal.Enable();
        fireNormal.performed += FireNormalBullet;

        fireSpecial = _playerControl.Player.FireSpecial;
        fireSpecial.Enable();
        fireSpecial.performed += FireSpecialBullet;
    }

    private void OnDisable()
    {
        move.Disable();
        fireNormal.Disable();
        fireSpecial.Disable();
    }

    private void Update()
    {
        moveDirection = move.ReadValue<Vector2>();

    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    private void FireNormalBullet(InputAction.CallbackContext context)
    {
        Debug.Log("Fire!!");
    }

    private void FireSpecialBullet(InputAction.CallbackContext context)
    {
        Debug.Log("Fire Special!!");
    }

}
