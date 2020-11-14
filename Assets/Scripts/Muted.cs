using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Muted : MonoBehaviour
{
    private SoundOn music;
    public Button musicToggleButton;
    public Sprite audioOn;
    public Sprite audioOff;

    void Start()
    {
        music = GameObject.FindObjectOfType<SoundOn>();
        UpdateIcon();
    }
    public void PauseMusic()
    {
        music.ToggleSound();
        UpdateIcon();
    }

    void UpdateIcon()
    {
        if(PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            AudioListener.volume = 1;
            musicToggleButton.GetComponent<Image>().sprite = audioOn;
        }
        else
        {
            AudioListener.volume = 0;
            musicToggleButton.GetComponent<Image>().sprite = audioOff;
        }
    }    
}

