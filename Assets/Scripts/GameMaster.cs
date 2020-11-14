using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public void GoToGameScene()
    {
        SceneManager.LoadScene("Game");
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void SceneLoader()
    {
        SceneManager.LoadScene("Shop");
    }
}
