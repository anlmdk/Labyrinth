using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance { get; private set; }

    [Header("References")]

    [SerializeField] private InputHandler inputHandler;

    [Header("Settings")]

    [SerializeField] private float speed = 5f;
    [SerializeField] private float jump = 5f;

    Rigidbody2D rb;

    private bool isFacing = true;
    private bool isGrounded = true;  // Zýplama kontrolü için


    private void Awake()
    {
        instance = this;

        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Movement();
        if (inputHandler.GetJump() && isGrounded)
        {
            Jump();
        }
    }
    private void Movement()
    {
        Vector2 input = inputHandler.GetMovementNormalized();

        rb.velocity = new Vector2(input.x * speed, input.y);

        if (!isFacing && input.x > 0f)
        {
            Flip();
        }
        else if (isFacing && input.x < 0f)
        {
            Flip();
        }
    }
    public void Flip()
    {
        isFacing = !isFacing;
        Vector3 _localScale = transform.localScale;
        _localScale.x *= -1f;
        transform.localScale = _localScale;
    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jump);
        isGrounded = false;
        StartCoroutine(ResetJump());
    }
    private IEnumerator ResetJump()
    {
        yield return new WaitForSeconds(0.5f);  // Zýplama süresini ayarlayabilirsiniz
        isGrounded = true;
    }
}
