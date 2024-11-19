using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusicManager : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip battleMusic;  // Clip for battle music
    public AudioClip victoryMusic; // Clip for victory music

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayBattleMusic(); // Start the game with battle music
    }

    public void PlayBattleMusic()
    {
        if (audioSource != null)
        {
            audioSource.clip = battleMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public void PlayVictoryMusic()
    {
        if (audioSource != null)
        {
            audioSource.clip = victoryMusic;
            audioSource.loop = false; // Play once
            audioSource.Play();
        }
    }

    public void StopMusic()
    {
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
