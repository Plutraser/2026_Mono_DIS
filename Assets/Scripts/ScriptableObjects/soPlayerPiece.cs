using UnityEngine;

/// <summary>
/// Data (read): Holds information for all player pieces
/// </summary>
/// 

public enum ePlayerPiece
{
    battleship,
    car,
    cat,
    dog,
    hat,
    shoe,
    thimble,
    wheelbarrow,
    terminator
}

[CreateAssetMenu(fileName = "New Player Piece", menuName = "Scriptable Objects/Create Player Piece")]
public class soPlayerPiece : ScriptableObject
{
    public ePlayerPiece playerPiece;
    public string playerPieceName;
    public Sprite playerPieceArt;
}
