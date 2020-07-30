using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uuspeliskripti : MonoBehaviour {
    
    void Start() {}

    void Update() {}

    public void Load() {
                SceneManager.LoadScene("mouseorcontroller");  
                PlayerPrefs.SetString("ladattu", "ei");

    }
    public void Quit(){
            Application.Quit();
    }
}
