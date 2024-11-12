using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightController : MonoBehaviour
{
    public ArrowController arrowController; // Reference to the ArrowController script
    public Transform[] shootingPositions; // Positions where the knight can shoot from
    public GameManager gameManager; // Reference to the GameManager

    private int chosenBox = -1; // Stores which box the knight will shoot at

    // Update is called once per frame
    void Update()
    {
        // Handle shooting when a button is pressed (you can customize this as needed)
        if (Input.GetKeyDown(KeyCode.Alpha1)) // If button 1 is pressed
        {
            chosenBox = 0;
            ShootArrow();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) // If button 2 is pressed
        {
            chosenBox = 1;
            ShootArrow();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) // If button 3 is pressed
        {
            chosenBox = 2;
            ShootArrow();
        }
    }

    // Shoot an arrow at the selected box
    private void ShootArrow()
    {
        if (chosenBox >= 0 && chosenBox < gameManager.boxes.Length)
        {
            // Get the box the knight selected to shoot at
            BoxController targetBox = gameManager.boxes[chosenBox];

            // Fire the arrow at the target box
            arrowController.FireArrow(shootingPositions[chosenBox].position, targetBox);
        }
    }
}
