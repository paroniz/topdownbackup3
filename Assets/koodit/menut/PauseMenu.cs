using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
    
    public static bool GameIsPaused = false;
    public GameObject pausemenu;
    public GameObject paneeli;
    public GameObject canvas2;
    private GameObject hero;

    void Start() {}

    void Update() {
        if((Input.GetKeyDown(KeyCode.Escape) || (Input.GetButtonDown("Start"))) && (!canvas2.active))
        {
            if (GameIsPaused)
            {
                Resume();

            }
            else
            {
                Pause();
            }
        }
        hero = GameObject.FindWithTag("hero");
    }

   public void Resume()
    {
        pausemenu.SetActive(false);
        paneeli.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
        
        if(hero.GetComponent<joystickrotaatio>().enabled == true)
        {
            Cursor.visible = false;
        }
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
        SceneManager.LoadScene("mainmenu2");
        Debug.Log("Quittest");
    }
}