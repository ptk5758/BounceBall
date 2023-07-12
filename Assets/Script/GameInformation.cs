using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInformation
{
    GameManager gameManager;
    GameUI gameUI;
    public static float playTime;

    public GameInformation(GameManager gameManager)
    {
        this.gameManager = gameManager;
        this.gameUI = gameManager.gameUI;
        playTime = 0f;
    }

    public void Run()
    {
        if (GameManager.isStop) return;
        playTime += Time.deltaTime;
        gameUI.SetPlayTime(playTime);
    }
}