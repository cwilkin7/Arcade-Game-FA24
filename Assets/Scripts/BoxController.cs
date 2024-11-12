using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    public LizardWizardController lizardWizard;
    public KnightController knight;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha4)) lizardWizard.ChooseBox(0);
        if (Input.GetKeyDown(KeyCode.Alpha5)) lizardWizard.ChooseBox(1);
        if (Input.GetKeyDown(KeyCode.Alpha6)) lizardWizard.ChooseBox(2);

   
        if (Input.GetKeyDown("space")) knight.GuessBox(0);
        if (Input.GetKeyDown("v")) knight.GuessBox(1);
        if (Input.GetKeyDown("b")) knight.GuessBox(2);
    }
}