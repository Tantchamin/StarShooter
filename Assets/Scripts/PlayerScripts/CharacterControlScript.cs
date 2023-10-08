using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class CharacterControlScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;

    [SerializeField] private float moveSpeed;

    [SerializeField] private List<GameObject> bulletList;

    [SerializeField] private List<GameObject> shootPoints;

    [SerializeField] private CharacterStatusScript characterStatusScript;

    [SerializeField] private List<Button> cardButton;

    [SerializeField] private GameObject cardFolder;

    private PlayerControls _playerControl;

    private Vector2 moveDirection;

    private InputAction move, fireNormal, fireSpecial, selectCard1, selectCard2, selectCard3;

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

        selectCard1 = _playerControl.Player.SelectCard1;
        selectCard1.Enable();
        selectCard1.performed += Card1Select;

        selectCard2 = _playerControl.Player.SelectCard2;
        selectCard2.Enable();
        selectCard2.performed += Card2Select;

        selectCard3 = _playerControl.Player.SelectCard3;
        selectCard3.Enable();
        selectCard3.performed += Card3Select;
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
        Instantiate(bulletList[0], shootPoints[0].transform.position, shootPoints[0].transform.rotation);
        
    }

    private void FireSpecialBullet(InputAction.CallbackContext context)
    {
        Debug.Log("Fire Special!!");
        if(characterStatusScript.GetMissileAmount() != 0)
        {
            Instantiate(bulletList[1], shootPoints[0].transform.position, shootPoints[0].transform.rotation);
            characterStatusScript.MissileAmountAdjust(-1);
        }

    }

    private void Card1Select(InputAction.CallbackContext context)
    {
        if (cardFolder.activeSelf)
        {
            cardButton[0].onClick.Invoke();
        }

    }

    private void Card2Select(InputAction.CallbackContext context)
    {
        if (cardFolder.activeSelf)
        {
            cardButton[1].onClick.Invoke();
        }

    }

    private void Card3Select(InputAction.CallbackContext context)
    {
        if(cardFolder.activeSelf)
        {
            cardButton[2].onClick.Invoke();
        }
    }

}
