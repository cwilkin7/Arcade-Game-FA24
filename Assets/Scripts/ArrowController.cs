using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    // Reference to the Arrow's Rigidbody for movement
    public Rigidbody2D rb;
    // Arrow speed
    public float speed = 10f;

    // Reference to the BoxController
    public BoxController targetBox;

    // Flag to check if the arrow is fired
    private bool isFired = false;

    // Update is called once per frame
    void Update()
    {
        if (isFired)
        {
            MoveArrow();
        }
    }

    // Fires the arrow towards the target box
    public void FireArrow(Vector3 targetPosition, BoxController box)
    {
        isFired = true;
        targetBox = box;
        Vector3 direction = (targetPosition - transform.position).normalized;
        rb.velocity = direction * speed;
    }

    // Move the arrow
    private void MoveArrow()
    {
        // Check if the arrow collides with a box
        if (targetBox != null && Vector3.Distance(transform.position, targetBox.transform.position) < 0.5f)
        {
            targetBox.HitBox(); // Call HitBox on the target box when arrow hits
            Destroy(gameObject); // Destroy the arrow after hit
        }
    }
}
