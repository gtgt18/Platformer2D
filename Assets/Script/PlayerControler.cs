using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour

{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    private Rigidbody2D rb;
    private float moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Отримуємо напрямок руху
        moveInput = Input.GetAxisRaw("Horizontal");

        // Рух
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // БЕЗКІНЕЧНИЙ стрибок — без перевірки на землю!
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
    

