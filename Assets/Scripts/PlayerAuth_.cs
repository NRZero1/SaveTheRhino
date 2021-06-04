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
