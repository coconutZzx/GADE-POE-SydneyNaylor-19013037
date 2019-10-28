using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    //bool isPaused;

    //public void PauseGame()
    //{
    //    if (isPaused)
    //    {
    //        isPaused = false;
    //        Time.timeScale = 1;
    //    }
    //    if (!isPaused)
    //    {
    //        isPaused = true;
    //        Time.timeScale = 0;
    //    }
    //}
    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    
    void Paused()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
}
