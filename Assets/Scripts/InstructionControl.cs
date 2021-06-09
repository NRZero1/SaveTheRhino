using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionControl : MonoBehaviour
{
    public Button Next1;
    public Button Next2;
    public Button Next3;
    public Button Next4;
    public Button Next5;
    public Button Next6;
    public Button Next7;
    public GameObject WelcomePanel;
    public GameObject ObjectivePanel;
    public GameObject EnemyPanel;
    public GameObject AlliesPanel;
    public GameObject HowToPlayPanel;
    public GameObject HowToPlayPanel1;
    public GameObject HowToPlayPanel2;
    public GameObject HowToPlayPanel3;
    public SceneControl sceneControl;
    void Start()
    {
        WelcomePanel.SetActive(true);
        ObjectivePanel.SetActive(false);
        EnemyPanel.SetActive(false);
        AlliesPanel.SetActive(false);
        HowToPlayPanel.SetActive(false);
        HowToPlayPanel1.SetActive(false);
        HowToPlayPanel2.SetActive(false);
        HowToPlayPanel3.SetActive(false);
    }

    public void btnNextClick1()
    {
        WelcomePanel.SetActive(false);
        ObjectivePanel.SetActive(true);
    }

    public void btnNextClick2()
    {
        ObjectivePanel.SetActive(false);
        EnemyPanel.SetActive(true);
    }

    public void btnNextClick3()
    {
        EnemyPanel.SetActive(false);
        AlliesPanel.SetActive(true);
    }

    public void btnNextClick4()
    {
        AlliesPanel.SetActive(false);
        HowToPlayPanel.SetActive(true);
    }

    public void btnNextClick5()
    {
        HowToPlayPanel.SetActive(false);
        HowToPlayPanel1.SetActive(true);
    }

    public void btnNextClick6()
    {
        HowToPlayPanel1.SetActive(false);
        HowToPlayPanel2.SetActive(true);
    }

    public void btnNextClick7()
    {
        HowToPlayPanel2.SetActive(false);
        HowToPlayPanel3.SetActive(true);
    }
}
