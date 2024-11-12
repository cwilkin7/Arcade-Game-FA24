using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowController : MonoBehaviour
{
    public GameObject arrowPrefab;        // The arrow prefab to instantiate
    public Transform bowTransform;        // The transform of the bow to fire from
    public float arrowSpeed = 20f;        // Speed at which the arrow travels
    public float maxShootDistance = 20f;  // Maximum distance the arrow can travel

    private bool canShoot = true;         // To ensure the player can shoot only when allowed

    // Method to shoot the arrow when called
    public void FireArrow(BoxController targetBox)
    {
        if (!canShoot) return;

        // Instantiate the arrow
        GameObject arrow = Instantiate(arrowPrefab, bowTransform.position, bowTransform.rotation);
        
        // Set the direction of the arrow
        Vector3 direction = (targetBox.transform.position - bowTransform.position).normalized;
        
        // Get the Rigidbody component of the arrow to apply force
        Rigidbody rb = arrow.GetComponent<Rigidbody>();
        rb.velocity = direction * arrowSpeed;

        // Disable shooting for a short time (cooldown)
        canShoot = false;
        StartCoroutine(ShootCooldown());
    }

    // Cooldown period between shots
    private IEnumerator ShootCooldown()
    {
        yield return new WaitForSeconds(1f); // 1 second cooldown between shots
        canShoot = true;
    }
}
