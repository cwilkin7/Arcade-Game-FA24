using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TMP_Text winnerText; //Fix Open Project

    void Start()
    {
          Cursor.visible = false;
    }
    
    
    
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    } 

	
   

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ShowWinnerText(string winner)
    {
        winnerText.text = winner + " Wins!";
        winnerText.gameObject.SetActive(true);

        
        Time.timeScale = 0f;
    }
}




