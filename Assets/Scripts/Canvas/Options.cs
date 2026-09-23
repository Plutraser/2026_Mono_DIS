using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Canvas: Input: Music and Volume Slider, controls game options
/// </summary>

public class Options : MonoBehaviour
{
    public Slider musicSlider;
    public Slider effectsSlider;

    private void Start()
    {
        musicSlider.value = AudioManager.Instance.volume[(int)eMixers.music];
        effectsSlider.value = AudioManager.Instance.volume[(int)eMixers.effects];
    }

    public void OnMusicSliderChanged(float _value)
    {
        AudioManager.Instance.SetMixerLevel(eMixers.music, _value);
    }

    public void OnEffectsSliderChanged(float _value)
    {
        AudioManager.Instance.SetMixerLevel(eMixers.effects, _value);
    }

    public void OnBackClicked()
    {
        Debug.Log("<color=green>OnBackClicked</color>");
        AudioManager.PlayClick();
        Destroy(gameObject);
    }
}
