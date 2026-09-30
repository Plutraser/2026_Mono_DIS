using UnityEngine;

/// <summary>
/// Data (read): Holds information for all player types (non, human, AI)
/// </summary>
/// 

public enum ePlayerType
{
    none,
    human,
    AI,
    terminator
}

[CreateAssetMenu(fileName = "New Player Type", menuName = "Scriptable Objects/Create Player Type")]
public class soPlayerTypes : ScriptableObject
{
    public ePlayerType playerType;
    public string playerTypeName;
    public Sprite playerTypeArt;
}
