using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public Button BackToMenuButton;
    public Button PlayButton;
    public GameObject LevelCanvasScreen;
    public GameObject MainMenuCanvas;
    public GameObject pauseMenuCanvas;
    public GameObject SettingsMenuCanvas;
    //public GameObject GameCanvas;
    void Start()
    {
        MainMenuCanvas.SetActive(true);
        LevelCanvasScreen.SetActive(false);
        pauseMenuCanvas.SetActive(false);
        //GameCanvas.SetActive(true);
    }

    
    void Update()
    {
        
    }
    public void PlayButtonClicked()
    {
        MainMenuCanvas.SetActive(false);
        LevelCanvasScreen.SetActive(true);
    }
    public void PauseButtonClicked()
    {
        Time.timeScale = 0;
        pauseMenuCanvas.SetActive(true);
    }
    public void ResumeButtonClicked()
    {
        Time.timeScale = 1;
        pauseMenuCanvas.SetActive(false);
    }
    public void SettingsButtonClicked()
    {
        Time.timeScale = 0;
        SettingsMenuCanvas.SetActive(true);
    }
    public void ExitSettingsButtonClicked()
    {
        Time.timeScale = 1;
        SettingsMenuCanvas.SetActive(false);
    }
    public void RestartLevelButtonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void QuitButtonClicked()
    {
        SceneManager.LoadScene(0);
    }
    public void BackToMainMenu()
    {
        MainMenuCanvas.SetActive(true);
        LevelCanvasScreen.SetActive(false);
    }
    public void Level1ButtonClicked(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
        Time.timeScale = 1;
    }
    public void Level2ButtonClicked(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
        Time.timeScale = 1;
    }
    public void Level3ButtonClicked(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
        Time.timeScale = 1;
    }
    public void Level4ButtonClicked(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
        Time.timeScale = 1;
    }
    public void Level5ButtonClicked(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
        Time.timeScale = 1;
    }
    public void FinishButtonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
    }

}
