using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallHighScore : MonoBehaviour
{
    public Text HS1_Username;
    public Text HS1_Score;
    public Text HS2_Username;
    public Text HS2_Score;
    public Text HS3_Username;
    public Text HS3_Score;
    void Start()
    {
        HS1_Username.text = PlayerPrefs.GetString("HS1_Username");
        HS1_Score.text = PlayerPrefs.GetInt("HS1_Score").ToString();
        HS2_Username.text = PlayerPrefs.GetString("HS2_Username");
        HS2_Score.text = PlayerPrefs.GetInt("HS2_Score").ToString();
        HS3_Username.text = PlayerPrefs.GetString("HS3_Username");
        HS3_Score.text = PlayerPrefs.GetInt("HS3_Score").ToString();
    }
}
