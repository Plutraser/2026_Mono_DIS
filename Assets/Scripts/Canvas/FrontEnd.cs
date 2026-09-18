using UnityEngine;

/// <summary>
/// Canvas: Input: Main Menu Buttons and their functionality
/// </summary>
public class FrontEnd : MonoBehaviour
{
    public void OnPlayNowClicked()
    {
        Debug.Log("<color=green>OnPlayNowClicked</color>");
        AudioManager.PlayClick();
    }
    public void OnOptionsClicked()
    {
        Debug.Log("<color=green>OnOptionsClicked</color>");
        AudioManager.PlayClick();
        CanvasManager.Instance.ShowCanvasOptions();
    }
}
