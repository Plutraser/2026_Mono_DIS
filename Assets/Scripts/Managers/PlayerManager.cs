using UnityEngine;

/// <summary>
/// Manager: Handles player methods, both creation and access to all of the players
/// </summary>

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;
    public const int maxPlayers = 4;

    public Player[] players;
    
    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        CreatePlayers(); //TODO: REMOVE THIS ONCE SCENEMGR IS IMPLEMENTED
    }

    public void CreatePlayers()
    {
        players = new Player[maxPlayers];
        for (int i = 0; i < maxPlayers; i++)
        {
            players[i] = new GameObject("Player " + (i + 1)).AddComponent<Player>();
            players[i].transform.SetParent(transform);
            players[i].playerIdx = i;
            players[i].soPlayerPiece = GameManager.Instance.so_Ref.playerPieces[i];
            players[i].soPlayerType = GameManager.Instance.so_Ref.playerTypes[(int)ePlayerType.none];

        }
        players[0].soPlayerType = GameManager.Instance.so_Ref.playerTypes[(int)ePlayerType.human];
        players[1].soPlayerType = GameManager.Instance.so_Ref.playerTypes[(int)ePlayerType.AI];
    }
}
