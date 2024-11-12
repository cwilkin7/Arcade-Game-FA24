using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Singleton instance
    public int knightHP = 3;
    public int lizardHP = 3;

    public Text knightHealthText; // Reference to the Knight's health text UI
    public Text lizardHealthText; // Reference to the Lizard's health text UI

    public BoxController[] boxes; // Array of boxes the knight can shoot at

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateHealthText(); // Initialize health display
    }

    // Decrease knight's HP when they miss
    public void DecreaseKnightHP()
    {
        knightHP--;
        UpdateHealthText();
        CheckGameOver();
    }

    // Decrease lizard's HP when found
    public void DecreaseLizardHP()
    {
        lizardHP--;
        UpdateHealthText();
        CheckGameOver();
    }

    // Check if the game is over
    private void CheckGameOver()
    {
        if (knightHP <= 0)
        {
            Debug.Log("Knight has lost! Game Over.");
            // Handle knight's loss (e.g., end game or restart)
        }

        if (lizardHP <= 0)
        {
            Debug.Log("Lizard has lost! Game Over.");
            // Handle lizard's loss (e.g., end game or restart)
        }
    }

    // Update health text UI for both players
    private void UpdateHealthText()
    {
        knightHealthText.text = "Knight HP: " + knightHP.ToString();
        lizardHealthText.text = "Lizard HP: " + lizardHP.ToString();
    }
}
