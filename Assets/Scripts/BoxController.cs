using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    // Reference to the GameManager
    public GameManager gameManager;

    // Is this box the one the Lizard Wizard is hiding behind?
    public bool isLizardBehindThisBox = false;

    // Called when an arrow hits the box
    public void HitBox()
    {
        if (isLizardBehindThisBox)
        {
            Debug.Log("Lizard found! The knight wins this round.");
            // Lizard gets hit, decrease Lizard's HP
            gameManager.DecreaseLizardHP();
        }
        else
        {
            Debug.Log("The knight missed! The knight loses 1 HP.");
            // Knight misses, decrease Knight's HP
            gameManager.DecreaseKnightHP();
        }
    }
}
