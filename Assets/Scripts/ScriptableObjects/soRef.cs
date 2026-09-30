using UnityEngine;

/// <summary>
/// Datae (read): A central storage area to reference other SO's, player colors, audio effects, etc.
/// </summary>

[CreateAssetMenu(fileName = "New Ref", menuName = "Scriptable Objects/Create Ref")]
public class soRef : ScriptableObject
{
    [NamedArray(typeof(ePlayerPiece))] public soPlayerPiece[] playerPieces;
    [NamedArray(typeof(ePlayerType))] public soPlayerTypes[] playerTypes;
}
