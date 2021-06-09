using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class bgmToggle : MonoBehaviour
{
    public Sprite toggleOnSprite;
    public Sprite toggleOffSprite;
    private bool isToggled = false;
    private Image image;
    private AudioSource audio;
    void Start()
    {
        image = GetComponent<Image>();
        audio = GetComponent<AudioSource>();
        UpdateSprite();
    }

    public void setBgmButton()
    {
        isToggled = !isToggled;
        UpdateSprite();
    }

    void UpdateSprite()
    {
        if(isToggled)
        {
            image.sprite = toggleOnSprite;
            audio.Play();
        }
        else
        {
            image.sprite = toggleOffSprite;
            audio.Stop();
        }
    }
}
