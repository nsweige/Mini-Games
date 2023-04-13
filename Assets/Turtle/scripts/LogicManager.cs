using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;

    public void addScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
