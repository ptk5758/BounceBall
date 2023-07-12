using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class GameUI
{
    [SerializeField]
    TMP_Text playTimeComponent;

    public void SetPlayTime(float playTime)
    {
        int second = (int) playTime % 60;
        int minute = (int) playTime / 60;
        playTimeComponent.text = "Play Time " + string.Format("{0:0#}", minute) + " : " + string.Format("{0:0#}", second);
    }   
}