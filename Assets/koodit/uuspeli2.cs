using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uuspeli2 : MonoBehaviour {
    
    void Start() {}

    void Update() {}

    public void Load() {
                SceneManager.LoadScene("ekascene");  
                PlayerPrefs.SetString("ladattu", "ei");
                PlayerPrefs.SetString("ohjain", "ei");
                Debug.Log("mouse");

    }

     public void Loadohjain() {
                SceneManager.LoadScene("ekascene");  
                PlayerPrefs.SetString("ladattu", "ei");
                 PlayerPrefs.SetString("ohjain", "joo");
                 Debug.Log("ohjain");

    }
    public void Quit(){
            Application.Quit();
    }
}
