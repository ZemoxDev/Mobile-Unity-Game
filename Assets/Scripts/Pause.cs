using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    bool isPaused = false;
    public GameObject PauseMenu;

    void Start()
    {
        PauseMenu.SetActive(false);
    }

    public void pauseGame()
    {
        PauseMenu.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;
    }
    public void resumeGame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }
}
