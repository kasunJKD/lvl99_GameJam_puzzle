using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public AudioMixer audioMixer;
    public Slider volumeSlider;

    void Start()
    {
        float volume = 0;
        audioMixer.GetFloat("Volume", out volume);
        volumeSlider.value = volume;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    public void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void SetVolume(float volume) {
        
        audioMixer.SetFloat("Volume", volume);
    }

    public void QuitGame() {
         //Application.Quit();
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("QuitGame"); 
    }
}
