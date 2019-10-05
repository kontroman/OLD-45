using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    private bool isJumping = false;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            isJumping = true;
        }
        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(x * speed, rb.velocity.y, 0);
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isJumping = false;
        }

        if (col.collider.gameObject.layer == LayerMask.NameToLayer("2"))
        {
            Debug.Log("Layer 2");
        }
    }
}
