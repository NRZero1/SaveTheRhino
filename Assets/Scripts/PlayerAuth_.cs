using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAuth_ : MonoBehaviour
{
    public InputField Username;
    public InputField Password;
    public SceneControl sceneControl;
    public MenuControl menuControl;
    
    public void Login()
    {
        string UsernameKey = Username.text;
        string UsernameText = Username.text;
        string PasswordText = Password.text;
        
        if (Username.text == PlayerPrefs.GetString("username_" + UsernameKey)) {
            if (Password.text == PlayerPrefs.GetString("password_" + UsernameKey)) {
                PlayerPrefs.SetString("session_name", UsernameKey);
                PlayerPrefs.SetInt("session_score", 0);

                if (!PlayerPrefs.HasKey("HS1_Username"))
                {
                    PlayerPrefs.SetString("HS1_Username", "Empty");
                    PlayerPrefs.SetInt("HS1_Score", 0);

                    if (!PlayerPrefs.HasKey("HS2_Username"))
                    {
                        PlayerPrefs.SetString("HS2_Username", "Empty");
                        PlayerPrefs.SetInt("HS2_Score", 0);

                        if (!PlayerPrefs.HasKey("HS3_Username"))
                        {
                            PlayerPrefs.SetString("HS3_Username", "Empty");
                            PlayerPrefs.SetInt("HS3_Score", 0);
                        }
                    }
                }

                sceneControl.sceneLoader("MainMenu");
            } else {
                menuControl.ErrorOpen();
            }
        } 
        else 
        {
            if (string.IsNullOrEmpty(UsernameText)) {
                menuControl.ErrorOpen();
            }  
            if (string.IsNullOrEmpty(PasswordText)) {
                menuControl.ErrorOpen();
            }
        }
    }
}
