using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musakoodi1 : MonoBehaviour {
    
    void Start() 
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update() 
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName ("ekascene"))
        {
            Destroy(gameObject); 
        }
    }
}
