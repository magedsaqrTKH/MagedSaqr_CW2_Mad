using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontalInput;
    float moveSpeed = 8f;
    bool isFacingRight = false;

    Rigidbody2D rb;
    Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        FlipSprite();

        // Set animator parameter based on movement input
        animator.SetFloat("Speed", Mathf.Abs(horizontalInput));

        // Move the player
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
    }

    void FlipSprite()
    {
        if (isFacingRight && horizontalInput > 0f || !isFacingRight && horizontalInput < 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }
}
