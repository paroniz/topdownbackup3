using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuunvaihtokoodi : MonoBehaviour {
    
    void Start() {}

    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)){
Application.LoadLevel("mainmenu");
}
    }
}
