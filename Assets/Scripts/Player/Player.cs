using UnityEngine;

/// <summary>
/// Data (read / Write): holds player information (which can change)
/// at runtime in Front End and InGame
/// </summary>
public class Player : MonoBehaviour
{
    [Header("Setup")]
    public int playerIdx;
    public string playerName;
    public soPlayerTypes soPlayerType;
    public soPlayerPiece soPlayerPiece;
}
