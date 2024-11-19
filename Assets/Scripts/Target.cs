using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public string winnerName; // The name of the winner if this target is hit

    public void AnnounceWinner()
    {
        // Display the winner
        Debug.Log(winnerName + " Wins!");

        GameObject.FindObjectOfType<GameMusicManager>().PlayVictoryMusic();


        // Optionally, display on UI
        GameManager.Instance.ShowWinnerText(winnerName);

        HandleWin();
    }
    
    void HandleWin()
    {
        Time.timeScale = 0; 
    }

}
