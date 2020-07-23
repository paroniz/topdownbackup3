using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {
    
    public static bool GameIsPaused = false;
    public GameObject pausemenu;
    public GameObject paneeli;
    public GameObject canvas2;

    void Start() {}

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape) &&  (!canvas2.active))
        {
            if (GameIsPaused)
            {
                Resume();

            }else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause ()
    {
        pausemenu.SetActive(true);
        paneeli.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

     public void Quit ()
    {
        Application.Quit();
        Debug.Log("Quittest");
    }
}