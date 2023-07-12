using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameInformation gameInformation;
    public static bool isStop;

    private void Awake()
    {
        gameInformation = new GameInformation();
        isStop = false;
    }

    private void Update()
    {
        gameInformation.Run();
        Debug.Log(GameInformation.playTime);
    }
}
class GameInformation
{
    public static float playTime;
    public GameInformation()
    {
        playTime = 0f;
    }
    public void Run()
    {
        if (GameManager.isStop) return;
        playTime += Time.deltaTime;
    }
}