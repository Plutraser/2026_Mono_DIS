using UnityEngine;

public class wSetup : MonoBehaviour
{
    public GameObject buttonAddPlayer;
    public GameObject Grp_PlayerButtons;

    public void InitWidget()
    {
        buttonAddPlayer.SetActive(true);
        Grp_PlayerButtons.SetActive(false);
    }

    public void OnPieceClicked()
    {
        Debug.Log("<color=green>OnPieceClicked</color>");
        AudioManager.PlayClick();
    }
    public void OnTypeClicked()
    {
        Debug.Log("<color=green>OnTypeClicked</color>");
        AudioManager.PlayClick();
    }
}
