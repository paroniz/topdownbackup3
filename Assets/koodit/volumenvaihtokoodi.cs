﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class volumenvaihtokoodi : MonoBehaviour {
    
    int volume;
    float currentvolume;

    void Start() 
    {
        PlayerPrefs.SetFloat("volume",1f);
    }

    void Update() {}

    public void VolumeUp()
    {
        currentvolume = PlayerPrefs.GetFloat("volume");
       
        if (currentvolume< 1.5f)
        {
            currentvolume += 0.1f;
            Debug.Log("volumeup");
            PlayerPrefs.SetFloat("volume", currentvolume);
            AudioListener.volume = PlayerPrefs.GetFloat("volume");
       }
    }

    public void VolumeDown()
    {
        currentvolume = PlayerPrefs.GetFloat("volume");
        currentvolume -= 0.1f;

        //Debug.Log("down");
        PlayerPrefs.SetFloat("volume", currentvolume);
        AudioListener.volume = PlayerPrefs.GetFloat("volume");
    }
}
