using System;
using UnityEngine;
using UnityEngine.Audio;

/// <summary>
/// Manager: Handles audio in the game
/// </summary>
/// 

public enum eMixers
{
    music,
    effects
}

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;


    public AudioMixerGroup[] mixers;
    public float[] volume = { 1f, 1f };
    private string[] strMixers = { "MusicVol", "EffectsVol" };

    public AudioSource Effects;
    public AudioClip Click;

    // Update is called once per frame
    private void Awake()
    {
        Instance = this;
    }

    public void SetMixerLevel (eMixers _mixer, float _soundLevel)
    {
        mixers[(int)_mixer].audioMixer.SetFloat(strMixers[(int)_mixer], Mathf.Log10(_soundLevel) * 20f); //db value
        volume[(int)_mixer] = _soundLevel; // 0 to 1 value
    }

    public static void PlayClick()
    {
        Instance.Effects.PlayOneShot(Instance.Click);
    }
}
