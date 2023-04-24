using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    public Slider healthbar;

    void Update()
    {
        if(healthbar.value == 0f) {
            PlayerDead();
        }
    }

    public void Retry()
    {
        gameOverUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
       gameOverUI.SetActive(false);
       SceneManager.LoadScene("MainMenu");
       //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void PlayerDead() {
        GameManager.instance.DisableInput();
        gameOverUI.SetActive(true);
    }
}
