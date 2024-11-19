using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject arrowPrefab; // The arrow prefab
    public Transform firePoint;    // Where the arrow spawns
    public float shootForce = 20f; // Force of the arrow when shot

    public string joystickHorizontal; // Input for horizontal movement
    public string joystickVertical;   // Input for vertical movement
    public string fireButton;         // Input for shooting

    void Update()
    {
        // Check for shooting input
        if (Input.GetButtonDown(fireButton))
        {
            Shoot();
        }

        // Optional: Handle joystick movement for aiming (if needed)
        // You can customize how you want to use the joystick keys here
    }

    void Shoot()
    {
        // Instantiate the arrow
        GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);

        // Add force to the arrow
        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * shootForce, ForceMode2D.Impulse);
    }
}
