using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;

    public void Retry()
    {
        gameOverUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
       gameOverUI.SetActive(false);
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void PlayerDead() {
        Debug.Log("Player Dead");
        gameOverUI.SetActive(true);
    }
}
