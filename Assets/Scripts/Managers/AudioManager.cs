using System;
using UnityEngine;

/// <summary>
/// Manager: Handles audio in the game
/// </summary>

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public AudioSource Effects;
    public AudioClip Click;

    // Update is called once per frame
    private void Awake()
    {
        Instance = this;
    }

    public static void PlayClick()
    {
        Instance.Effects.PlayOneShot(Instance.Click);
    }
}
