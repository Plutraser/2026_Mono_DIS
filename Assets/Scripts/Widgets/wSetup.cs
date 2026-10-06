using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class wSetup : MonoBehaviour
{
    public GameObject buttonAddPlayer;
    public GameObject Grp_PlayerButtons;

    public Image imagePiece;
    public TMP_Text textPiece;
    public Image imageType;
    public TMP_Text textType;

    private Player player;

    public void InitWidget(Player _player)
    {
        player = _player;
        ShowButton();
    }

    void ShowButton()
    {
        imagePiece.sprite = player.soPlayerPiece.playerPieceArt;
        textPiece.text = player.soPlayerPiece.playerPieceName;
        imageType.sprite = player.soPlayerType.playerTypeArt;
        textType.text = player.soPlayerType.playerTypeName;

        buttonAddPlayer.SetActive(player.soPlayerType.playerType == ePlayerType.none);
        Grp_PlayerButtons.SetActive(player.soPlayerType.playerType != ePlayerType.none);
    }

    public void OnPieceClicked()
    {
        Debug.Log("<color=green>OnPieceClicked</color>");
        AudioManager.PlayClick();
        // Increment the soPlayerPiece at Player, and reset at terminator 
        player.IncrementPlayerPiece();
        ShowButton();
    }
    public void OnTypeClicked()
    {
        Debug.Log("<color=green>OnTypeClicked</color>");
        AudioManager.PlayClick();
        player.IncrementPlayerType();
        ShowButton();
    }
}
