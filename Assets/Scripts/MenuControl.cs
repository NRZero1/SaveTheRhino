using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    public GameObject exitPanel;
    public GameObject errorPanel;
    
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

    public void ErrorOpen()
    {
        errorPanel.SetActive(true);
    }

    public void ErrorClose()
    {
        errorPanel.SetActive(false);
    }

    void Start()
    {
        exitPanel.SetActive(false);
        errorPanel.SetActive(false);
    }
}
