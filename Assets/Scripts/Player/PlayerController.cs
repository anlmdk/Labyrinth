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

    Rigidbody2D rb;

    Animator anim;

    private bool isFacing = true;

    private void Awake()
    {
        instance = this;

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        // Karakterin hareketi ve animasyonu

        Vector2 input = inputHandler.GetMovementNormalized();

        rb.velocity = new Vector2(input.x * speed, input.y * speed);

        anim.SetFloat("Horizontal", rb.velocity.x);
        anim.SetFloat("Vertical", rb.velocity.y);
        anim.SetFloat("Speed", rb.velocity.sqrMagnitude);

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
        // Karakterin saða sola yön olarak dönmesi

        isFacing = !isFacing;
        Vector3 _localScale = transform.localScale;
        _localScale.x *= -1f;
        transform.localScale = _localScale;
    }
}
