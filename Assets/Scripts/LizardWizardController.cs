using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LizardWizardController : MonoBehaviour
{
    public BoxController[] boxes; // All boxes the Lizard can hide behind
    public int selectedBox = -1; // The box the Lizard will hide behind

    // Update is called once per frame
    void Update()
    {
        // Select box using button presses (you can customize the input scheme)
        if (Input.GetKeyDown(KeyCode.Alpha1)) // If button 1 is pressed
        {
            selectedBox = 0;
            HideLizard();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) // If button 2 is pressed
        {
            selectedBox = 1;
            HideLizard();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) // If button 3 is pressed
        {
            selectedBox = 2;
            HideLizard();
        }
    }

    // Hide the lizard behind the selected box
    private void HideLizard()
    {
        // Set the box the lizard will hide behind
        for (int i = 0; i < boxes.Length; i++)
        {
            boxes[i].isLizardBehindThisBox = (i == selectedBox);
        }
    }
}
