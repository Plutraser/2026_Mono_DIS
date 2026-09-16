using System;
using UnityEngine;

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
}
