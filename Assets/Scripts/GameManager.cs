using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int knightHP = 3;
    public int lizardWizardHP = 3;
    public KnightController knight;
    public LizardWizardController lizardWizard;

    public void OnKnightMiss()
    {
        knightHP--;
        Debug.Log("Knight guessed wrong! Knight HP: " + knightHP);
        CheckGameOver();
    }

    public void OnWizardHit()
    {
        lizardWizardHP--;
        Debug.Log("Knight guessed correctly! Wizard HP: " + lizardWizardHP);
        CheckGameOver();
    }

    private void CheckGameOver()
    {
        if (knightHP <= 0)
        {
            Debug.Log("Lizard Wizard wins!");
            // Handle end of game, e.g., reset or display victory screen
        }
        else if (lizardWizardHP <= 0)
        {
            Debug.Log("Knight wins!");
            // Handle end of game, e.g., reset or display victory screen
        }
    }
}




