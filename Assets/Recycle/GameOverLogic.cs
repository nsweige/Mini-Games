using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverLogic : MonoBehaviour
{
    public GameObject gameOverScreen;

    public void restartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
