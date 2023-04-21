using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    public GameObject gameOverUI;

    public void MainMenu()
    {
       gameOverUI.SetActive(false);
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void NextLevel()
    {
        gameOverUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void portaltriggerd() {
         gameOverUI.SetActive(true);
    }
}
