using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public float jumpForce = 10f; 
    public Transform firePoint;  
    public GameObject arrowPrefab; 
    public float shootForce = 20f;
    public float fireRate = 0.5f;

    private float nextFireTime = 0f;

    private Rigidbody2D rb;
    private bool isGrounded;

    public string horizontalAxis; 
    public string jumpButton;     
    public string fireButton;     

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Horizontal movement
        float move = Input.GetAxis(horizontalAxis) * moveSpeed;
        rb.velocity = new Vector2(move, rb.velocity.y);

        // Jumping
        if (Input.GetButtonDown(jumpButton) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        // Shooting
        if (Input.GetButtonDown(fireButton) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate; // Set the next fire time
        }
    }

    void Shoot()
    {
        // Instantiate and shoot the arrow
        GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rbArrow = arrow.GetComponent<Rigidbody2D>();
        rbArrow.velocity = firePoint.right * shootForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player is grounded
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
