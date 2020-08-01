using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionsesctweak : MonoBehaviour {
    

    public GameObject pausemenu;
    public GameObject asetukset;

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            asetukset.SetActive(false);
            pausemenu.SetActive(true);
        }
    }
}
