using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score, highScore;
    public Text scoreDisplay, highScoreDisplay;

    private void Awake()
    {
        instance = this;

        highScore = PlayerPrefs.GetInt("HighScore");
        highScoreDisplay.text = highScore.ToString();
    }
    private void Update()
    {
        scoreDisplay.text = score.ToString();
        highScoreDisplay.text = highScore.ToString();
    }

    public void UpdateHighscore()
    {
        if(score > highScore)
        {
            highScore = score;

            highScoreDisplay.text = highScore.ToString();

            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            //increase score by 1
            score++;
            UpdateHighscore();
        }
    }
    public void ResetScore()
    {
        score = 0;
        scoreDisplay.text = score.ToString();
    }
    public void ClearHighScore()
    {
        PlayerPrefs.DeleteKey("HighScore");

        highScore = 0;
        highScoreDisplay.text = highScore.ToString();
    }
}
