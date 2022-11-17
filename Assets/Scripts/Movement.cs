using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MovementSpeed;
    public float JumpForce;

    public int JumpCount;
    int maxJumpCount;
    bool grounded;
    Rigidbody2D rb;
    Animator anim;
    SpriteRenderer sr;

    private void Awake()
    {
        maxJumpCount = JumpCount;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        RigidbodyMovement();
        anim.SetFloat("MovementX", Mathf.Abs(rb.velocity.x));
        anim.SetBool("grounded", grounded);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        if (JumpCount > 0)
        {
            JumpCount--;
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            anim.Play("Jump");
        }
    }
    public void TransformMovement()
    {
        float movementDir = Input.GetAxisRaw("Horizontal");
        transform.position = new Vector2(transform.position.x + (MovementSpeed * movementDir * Time.deltaTime), transform.position.y);
    }
    public void RigidbodyMovement()
    {
        float movementDir = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(movementDir * MovementSpeed * Time.deltaTime, rb.velocity.y);
        if (rb.velocity.x < 0)
        {
            sr.flipX = true;
        }
        else if (rb.velocity.x > 0)
        {
            sr.flipX = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
        {
            JumpCount = maxJumpCount;
            grounded = true;
        }
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            collision.gameObject.transform.parent.gameObject.SetActive(false);
            //Destroy(collision.gameObject);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
        {
            grounded = false;
        }
    }
}
