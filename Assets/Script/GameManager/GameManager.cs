using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static bool isStop;
    public GameInformation gameInformation;
    public GameUI gameUI;

    private void Awake()
    {
        gameInformation = new GameInformation(this);
        isStop = false;
    }

    private void Update()
    {
        gameInformation.Run();
    }
}

