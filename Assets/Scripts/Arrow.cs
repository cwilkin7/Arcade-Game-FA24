using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 10f; 
    public float destroyBoundary = 15f; 
    private Vector2 startPosition;

    void Start()
    {
        startPosition = transform.position; 
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed; 
    }

    void Update()
    {
       
        if (Vector2.Distance(startPosition, transform.position) > destroyBoundary)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Target"))
        {
            Target target = collision.GetComponent<Target>();
            if (target != null)
            {
                target.AnnounceWinner(); // Announce the winner
            }

            Destroy(gameObject); // Destroy the arrow
        }
    }
}
