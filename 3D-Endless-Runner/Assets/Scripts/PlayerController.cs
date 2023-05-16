using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody playerRb;

    private PlayerInput playerMovementInput;

    private string moveAction = "Move";

    private float moveX;
    private float moveZ;

    void Start()
    {
        playerMovementInput = GetComponent<PlayerInput>();
        playerRb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        
    }

    void OnMove()
    {
        moveX = playerMovementInput.actions[moveAction].ReadValue<Vector2>().x;
        moveZ = playerMovementInput.actions[moveAction].ReadValue<Vector2>().y;

        playerRb.velocity = new Vector3(moveX * speed, 0, moveZ * speed).normalized;
    }
}
