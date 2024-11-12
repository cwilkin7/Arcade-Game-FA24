using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightController : MonoBehaviour
{
    public LizardWizardController lizardWizard; // Reference to the LizardWizard script
    public GameManager gameManager;

    public void GuessBox(int boxIndex)
    {
        if (boxIndex == lizardWizard.GetChosenBoxIndex())
        {
            gameManager.OnWizardHit();
        }
        else
        {
            gameManager.OnKnightMiss();
        }
    }
}
