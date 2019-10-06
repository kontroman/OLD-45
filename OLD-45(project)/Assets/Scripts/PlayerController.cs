using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Sprite sprite_right;
    public Sprite sprite_left;
    public Sprite sprite_default;

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
        if(gameObject.transform.position.y < -5)
        {
            GameController.RestartGame();
        }
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            isJumping = true;
        }
        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(x * speed, rb.velocity.y, 0);
        if (x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite_right;
        }
        else if(x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite_left;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite_default;
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            if(isJumping)
            CamShaker.DoShake(1, .5f);
            isJumping = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "level_2")
        {
            GameController.OpenLevel2();
            Destroy(collision.gameObject);
        }
    }

}
