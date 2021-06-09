using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    
    public GameObject LevelClear;
    public GameObject GameOver;
    void Start()
    {
        LevelClear.SetActive(false);
        GameOver.SetActive(false);
    }

    public void levelClearPanelShow()
    {
        LevelClear.SetActive(true);
        GameOver.SetActive(false);
    }

    public void gameOverPanelShow()
    {
        LevelClear.SetActive(false);
        GameOver.SetActive(true);
        PlayerPrefs.SetInt("session_score", 0);
        PlayerPrefs.SetInt("session_health", 3);
    }

    public void gameClear()
    {
        int currentScore = 0;
        
        currentScore = PlayerPrefs.GetInt("session_score");
        if (PlayerPrefs.GetString("HS1_Username") == "Empty")
        {
            PlayerPrefs.SetString("HS1_Username", PlayerPrefs.GetString("session_name"));
            PlayerPrefs.SetInt("HS1_Score", currentScore);
        }
        else
        {
            if (PlayerPrefs.GetInt("HS1_Score") < currentScore)
            {
                PlayerPrefs.SetString("HS1_Username", PlayerPrefs.GetString("session_name"));
                PlayerPrefs.SetInt("HS1_Score", currentScore);
            }
            else if (PlayerPrefs.GetInt("HS2_Score") < currentScore)
            {
                PlayerPrefs.SetString("HS2_Username", PlayerPrefs.GetString("session_name"));
                PlayerPrefs.SetInt("HS2_Score", currentScore);
            }
            else if (PlayerPrefs.GetInt("HS3_Score") < currentScore)
            {
                PlayerPrefs.SetString("HS3_Username", PlayerPrefs.GetString("session_name"));
                PlayerPrefs.SetInt("HS3_Score", currentScore);
            }
        }

        PlayerPrefs.SetInt("session_score", 0);
        PlayerPrefs.SetInt("session_health", 3);
    }
}
