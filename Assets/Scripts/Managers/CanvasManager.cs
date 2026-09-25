using System;
using UnityEngine;

/// <summary>
/// Manager: Handles canvas' and widgets throughout the game
/// </summary>

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        ShowCanvasFE();
    }

    public void ShowCanvasFE()
    {
        Instantiate(Resources.Load<GameObject>("Canvas/" + "CanvasFE"));
    }
    public void ShowCanvasOptions()
    {
        Instantiate(Resources.Load<GameObject>("Canvas/" + "CanvasOptions"));
    }

    public void ShowCanvasSetup()
    {
        Setup setup = Instantiate(Resources.Load<GameObject>("Canvas/" + "CanvasSetup")).GetComponent<Setup>();
        setup.InitCanvas();
    }
}
