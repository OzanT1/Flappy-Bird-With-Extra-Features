using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverCanvas;
    public GameObject PauseCanvas;


    void Awake()
    {
        GameOverCanvas.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        GameOverCanvas.SetActive(false);
        PauseCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void PauseGame()
    {
        PauseCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void UnPauseGame()
    {
        PauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }
    public void Replay()
    {
        SceneManager.LoadScene("GameRun");
    }
    public void openMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void exit()
    {
        Application.Quit();
    }
}
