using TMPro.Examples;
using UnityEngine;

/// <summary>
/// Manager: Handles the gameObjects that travel from scene to scene
/// </summary>

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public soRef so_Ref;

    private void Awake()
    {
        Instance = this;
        //ToDO: Set this up as a DontDestroyOnLoad to get to ingame scene
    }

    private void Start()
    {
        Debug.Log("<color=yellow>Starting Game</color>");
    }
}
