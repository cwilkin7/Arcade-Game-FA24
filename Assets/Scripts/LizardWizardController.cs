using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LizardWizardController : MonoBehaviour
{
    public Transform[] hidingBoxes; // Assign in Inspector
    private int chosenBoxIndex = -1;

    public void ChooseBox(int boxIndex)
    {
        if (boxIndex >= 0 && boxIndex < hidingBoxes.Length)
        {
            chosenBoxIndex = boxIndex;
            transform.position = hidingBoxes[boxIndex].position;
        }
    }

    public int GetChosenBoxIndex()
    {
        return chosenBoxIndex;
    }
}
