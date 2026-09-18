using UnityEngine;

/// <summary>
/// Canvas: Input: Music and Volume Slider, controls game options
/// </summary>

public class Options : MonoBehaviour
{
    public void OnBackClicked()
    {
        Debug.Log("<color=green>OnBackClicked</color>");
        AudioManager.PlayClick();
        Destroy(gameObject);
    }
}
