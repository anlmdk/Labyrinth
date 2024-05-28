using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{

    private PlayerInput playerInput;
    private InputAction movementAction;
    private InputAction jumpAction;

    private void Awake()
    {
        playerInput = new PlayerInput();

        movementAction = playerInput.Player.Movement;
        jumpAction = playerInput.Player.Jump;
    }

    private void OnEnable()
    {
        playerInput.Player.Enable();
    }
    private void OnDisable()
    {
        playerInput?.Player.Disable();
    }

    public Vector2 GetMovementNormalized()
    {
        return movementAction.ReadValue<Vector2>().normalized;
    }

    public bool GetJump()
    {
        return jumpAction.triggered;
    }

}
