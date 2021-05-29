using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRegister : MonoBehaviour
{
    public InputField Email;
    public InputField Username;
    public InputField Password;
    public GameObject registerSuccess;

    public void Register()
    {
        string UsernameKey = Username.text;

        PlayerPrefs.SetString("email_" + Username.text, Email.text);
        PlayerPrefs.SetString("username_" + Username.text, Username.text);
        PlayerPrefs.SetString("password_" + Username.text, Password.text);

        Debug.Log("Username: " + PlayerPrefs.GetString("username_" + Username.text));
        OpenPanel();
    }

    private void OpenPanel()
    {
        registerSuccess.SetActive(true);
    }

    public void ClosePanel()
    {
        registerSuccess.SetActive(false);
    }

    void Start()
    {
        registerSuccess.SetActive(false);
    }
}
