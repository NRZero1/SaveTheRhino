using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject aboutPanel;
    public GameObject exitPanel;
    public GameObject highscorePanel;
    
    public void ExitConfirm()
    {
        Application.Quit();
    }

    public void Exit()
    {
        exitPanel.SetActive(true);
    }

    public void ExitCancel()
    {
        exitPanel.SetActive(false);
    }

    public void About()
    {
        aboutPanel.SetActive(true);
    }

    public void AboutBack()
    {
        aboutPanel.SetActive(false);
    }

    public void HighScore()
    {
        highscorePanel.SetActive(true);
    }

    public void HighScoreBack()
    {
        highscorePanel.SetActive(false);
    }

    void Start()
    {
        aboutPanel.SetActive(false);
        exitPanel.SetActive(false);
        highscorePanel.SetActive(false);
    }
}

