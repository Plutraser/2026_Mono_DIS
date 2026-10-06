using UnityEngine;

public class Setup : MonoBehaviour
{
    public RectTransform Grp_PlayerButtons;

    public void InitCanvas()
    {
        for (int i = 0; i < PlayerManager.maxPlayers; i++)
        {
            wSetup w_Setup = Instantiate(Resources.Load<GameObject>("Widgets/" + "w_Setup"), Grp_PlayerButtons).GetComponent<wSetup>();
            w_Setup.InitWidget(PlayerManager.Instance.players[i]);
        }
    }
    public void OnCancelClicked()
    {
        Debug.Log("<color=green>OnCancelClicked</color>");
        AudioManager.PlayClick();
        Destroy(gameObject);
    }
}
