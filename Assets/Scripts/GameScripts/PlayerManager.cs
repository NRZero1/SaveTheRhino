using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour
{
    public int score = 0;
    public int health = 3;
    public Text lbl_Score;
    public Text lbl_Health;
    public UnityEvent game_complete;
    public UnityEvent game_lose;
    bool isEnd = false;

    void Start()
    {
        this.score = PlayerPrefs.GetInt("session_score");
        lbl_Score.text = "Score : " + this.score.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if(isEnd == false && GameObject.FindGameObjectsWithTag("Animal").Length == 0)
        {
            game_complete.Invoke();
            isEnd = true;
        }
        if (isEnd == false && health <= 0)
        {
            game_lose.Invoke();
            isEnd = true;
        }
    }

    public void takeDamage(int damage)
    {
        health -= damage;
        lbl_Health.text = "Health : " + health.ToString();
    }

    public void addScore(int score)
    {
        this.score += score;
        lbl_Score.text = "Score : " + this.score.ToString();
        PlayerPrefs.SetInt("session_score", this.score);
    }
}
